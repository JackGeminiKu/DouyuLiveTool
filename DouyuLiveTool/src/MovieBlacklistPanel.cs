using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using My.Windows.Forms;

namespace Douyu.src
{
    public partial class MovieBlacklistPanel : UserControl
    {
        IDbConnection _connection = new SqlConnection(Properties.Settings.Default.DouyuConnectionString);

        public MovieBlacklistPanel()
        {
            InitializeComponent();
        }

        private void MovieBlacklistPanel_Load(object sender, EventArgs e)
        {
            ShowSearchedMovies(txtMovieName.Text);
            ShowMovieBlacklist(txtSearchedBlacklist.Text);
        }

        IEnumerable<dynamic> _movies;

        private void btnFind_Click(object sender, EventArgs e)
        {
            ShowSearchedMovies(txtMovieName.Text);
        }

        private void txtMovieName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') ShowSearchedMovies(txtMovieName.Text);
        }

        void ShowSearchedMovies(string searchedMovie)
        {
            var sql = string.Format("select * from Movie");
            if (searchedMovie.Trim().Length != 0)
                sql += string.Format(" where MovieFile like '%{0}%'", searchedMovie);
            _movies = _connection.Query<dynamic>(sql);
            lbSearchedMovies.Items.Clear();
            foreach (var movie in _movies) {
                lbSearchedMovies.Items.Add(movie.MovieFile);
            }
        }

        private void lbSearchedMovies_DoubleClick(object sender, EventArgs e)
        {
            if (lbSearchedMovies.SelectedIndex < 0) return;

            var passwordBox = new PasswordBox();
            if (passwordBox.Show("确定要添加到黑名单?") == DialogResult.Cancel)
                return;
            if (passwordBox.Password != "123456") {
                MessageBox.Show("密码错误", "添加黑名单");
                return;
            }
            ImportToBlacklist(lbSearchedMovies.SelectedIndex);
            ShowMovieBlacklist(txtSearchedBlacklist.Text);
        }

        private void btnImportToBlacklist_Click(object sender, EventArgs e)
        {
            var passwordBox = new PasswordBox();
            if (passwordBox.Show("确定添加到黑名单?") == DialogResult.Cancel)
                return;
            if (passwordBox.Password != "123456") {
                MessageBox.Show("密码错误", "添加黑名单");
                return;
            }

            foreach (var i in lbSearchedMovies.SelectedIndices) {
                ImportToBlacklist((int)i);
            }
            ShowMovieBlacklist(txtSearchedBlacklist.Text);
            MessageBox.Show("导入完成!", "导入黑名单");
        }

        void ImportToBlacklist(int movieIndex)
        {
            var movie = _movies.ElementAt(movieIndex);
            var count = _connection.ExecuteScalar<int>("select * from MovieBlacklist where MovieId = @MovieId",
                new { MovieId = movie.Id });
            if (count != 0) {
                MessageBox.Show(string.Format("黑名单中已经有{0}了, 请不要重复导入!", movie.MovieName), "黑名单");
                return;
            }

            _connection.Execute("insert into MovieBlacklist(MovieId) values(@MovieId)", new { MovieId = movie.Id });
        }

        void ShowMovieBlacklist(string searchedWord)
        {
            var sql = "select Movie.Id, Movie.MovieName, Movie.MovieFile from MovieBlacklist " +
                "inner join Movie on MovieBlacklist.MovieId = Movie.Id";
            if (searchedWord.Trim().Length != 0)
                sql += string.Format(" where Movie.MovieFile like '%{0}%'", searchedWord);
            _blacklist = _connection.Query<dynamic>(sql);
            lbMovieBlacklist.Items.Clear();
            foreach (var movie in _blacklist) {
                lbMovieBlacklist.Items.Add(movie.MovieFile);
            }
        }

        IEnumerable<dynamic> _blacklist;

        private void btnSearchBlacklist_Click(object sender, EventArgs e)
        {
            ShowMovieBlacklist(txtSearchedBlacklist.Text);
        }

        private void txtSearchedBlacklist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') ShowMovieBlacklist(txtSearchedBlacklist.Text);
        }

        private void lbMovieBlacklist_DoubleClick(object sender, EventArgs e)
        {
            if (lbMovieBlacklist.SelectedIndex == -1)
                return;
            var movie = _blacklist.ElementAt(lbMovieBlacklist.SelectedIndex);

            var passwordBox = new PasswordBox();
            if (passwordBox.Show("确定要将{0}从黑名单中移除?", movie.MovieFile) == DialogResult.Cancel)
                return;
            if (passwordBox.Password != "123456") {
                MessageBox.Show("密码错误", "移除黑名单");
                return;
            }

            _connection.Execute("delete from MovieBlacklist where MovieId = @MovieId", new { MovieId = movie.Id });
            ShowMovieBlacklist(txtSearchedBlacklist.Text);
        }
    }
}
