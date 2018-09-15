using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using My.Windows.Forms;

namespace Douyu.src
{
    public partial class RoomMoviePanel : UserControl
    {
        IDbConnection _connection = new SqlConnection(Properties.Settings.Default.DouyuConnectionString);

        public RoomMoviePanel()
        {
            InitializeComponent();
        }

        int RoomId { get { return int.Parse(txtRoomId.Text); } }

        string SearchedMovie { get { return txtSearchedMovie.Text.Trim(); } }

        private void RoomMoviePanel_Load(object sender, EventArgs e)
        {
            ShowRoomMovies(RoomId);
            ShowSearchedMovies(SearchedMovie);
        }

        void ShowRoomMovies(int roomId)
        {
            var sql = "select RoomMovie.RoomId, Movie.Id, Movie.MovieName, Movie.MovieFile from RoomMovie " +
                "inner join Movie on RoomMovie.MovieId = Movie.Id " +
                "where RoomId = " + roomId;

            _roomMovies = _connection.Query<dynamic>(sql);

            lbRoomMovies.Items.Clear();
            foreach (var movie in _roomMovies) {
                lbRoomMovies.Items.Add(string.Format("{0} - {1}", movie.RoomId, movie.MovieFile));
            }

            lblRoomMovieCount.Text = string.Format("房间内共有{0}部电影!",_roomMovies.Count());
        }

        IEnumerable<dynamic> _roomMovies;

        void ShowSearchedMovies(string movieFile)
        {
            if (movieFile.Trim().Length == 0) {
                _searchedMovies = _connection.Query<dynamic>("select * from Movie");
            } else {
                var sql = string.Format("select * from Movie where MovieFile like '%{0}%'", movieFile);
                _searchedMovies = _connection.Query<dynamic>(sql);
            }

            lbSearchedMovies.Items.Clear();
            foreach (var movie in _searchedMovies) {
                lbSearchedMovies.Items.Add(movie.MovieFile);
            }

            lblSearchedMovieCount.Text = string.Format("共找到{0}部电影!",_searchedMovies.Count());
        }

        IEnumerable<dynamic> _searchedMovies;

        private void btnShowRoomMovies_Click(object sender, EventArgs e)
        {
            ShowRoomMovies(RoomId);
        }

        private void btnShowSearchedMovies_Click(object sender, EventArgs e)
        {
            ShowSearchedMovies(SearchedMovie);
        }

        private void btnAddMoviesToRoom_Click(object sender, EventArgs e)
        {
            var passwordBox = new PasswordBox();
            if (passwordBox.Show("确认要把电影添加到房间: " + RoomId, "添加电影") == DialogResult.Cancel) {
                return;
            }
            if (passwordBox.Password != "123456") {
                MessageBox.Show("密码错误!", "添加房间电影");
                return;
            }

            try {
                btnAddMoviesToRoom.Enabled = false;
                foreach (var item in lbSearchedMovies.SelectedIndices) {
                    AddMovieToRoom(_searchedMovies.ElementAt((int)item));
                }
                ShowRoomMovies(RoomId);
            } finally {
                btnAddMoviesToRoom.Enabled = true;
            }
        }

        private void btnDeleteRoomMovies_Click(object sender, EventArgs e)
        {
            var passwordBox = new PasswordBox();
            if (passwordBox.Show("确定要删除所选的电影? ") == DialogResult.Cancel) {
                return;
            }
            if (passwordBox.Password != "123456") {
                MessageBox.Show("密码错误!", "删除房间电影");
                return;
            }

            try {
                btnDeleteRoomMovies.Enabled = false;

                foreach (var item in lbRoomMovies.SelectedIndices) {
                    DeleteRoomMovie(_roomMovies.ElementAt((int)item));
                }
                ShowRoomMovies(RoomId);
            } finally {
                btnDeleteRoomMovies.Enabled = true;
            }
        }

        void AddMovieToRoom(dynamic movie)
        {
            // 房间里面已经有了?
            var count = _connection.ExecuteScalar<int>(
                "select * from RoomMovie where RoomId = @RoomId and MovieId = @MovieId",
                new { @RoomId = txtRoomId.Text, MovieId = movie.Id });
            if (count != 0) {
                MessageBox.Show(movie.MovieName + "已经添加到房间中, 请不要重复添加!", "房间电影");
                return;
            }

            // 添加到房间中
            _connection.Execute(
                "insert into RoomMovie(RoomId, MovieId, MovieScore, LastPlayTime) " +
                "values(@RoomId, @MovieId, 0, '2000-1-1 00:00:00')",
                new { RoomId = RoomId, MovieId = movie.Id });
        }

        void DeleteRoomMovie(dynamic movie)
        {
            _connection.Execute("delete from RoomMovie where RoomId = @RoomId and MovieId = @MovieId",
                new { RoomId = RoomId, MovieId = movie.Id });
        }

        private void txtRoomId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') ShowRoomMovies(RoomId);
        }

        private void txtSearchedMovie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') ShowSearchedMovies(SearchedMovie);
        }
    }
}
