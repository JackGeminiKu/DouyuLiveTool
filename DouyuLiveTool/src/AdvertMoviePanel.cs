using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Dapper;
using My.Windows.Forms;

namespace Douyu.src
{
    public partial class AdvertMoviePanel : UserControl
    {
        public AdvertMoviePanel()
        {
            InitializeComponent();
        }

        private void AdvertMoviePanel_Load(object sender, EventArgs e)
        {
            textBoxRoomId.Text = AppSettings.RoomId.ToString();
            ShowAdvertMovies();
        }

        private void buttonSelectDirectory_Click(object sender, EventArgs e)
        {
            var folderBroswer = new FolderBrowserDialog();
            if (folderBroswer.ShowDialog() == DialogResult.Cancel)
                return;

            ShowSearchedAdverts(textBoxAdvertDirectory.Text = folderBroswer.SelectedPath);
        }

        void ShowSearchedAdverts(string path)
        {
            var movies = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            listBoxSearchedAdverts.Items.Clear();
            listBoxSearchedAdverts.Items.AddRange(movies.ToArray());
        }

        private void buttonSaveAsRoomAdvert_Click(object sender, EventArgs e)
        {
            var passwordBox = new PasswordBox();
            if (passwordBox.Show("确定要设置为房间广告?") == DialogResult.Cancel)
                return;
            if (passwordBox.Password != "123456") {
                MessageBox.Show("密码错误!", "修改房间广告");
                return;
            }

            var count = _conn.ExecuteScalar<int>(
                "select count(*) from AdvertMovie where RoomId = @RoomId",
                new { RoomId = int.Parse(textBoxRoomId.Text) });
            if (count != 0) {
                _conn.Execute("update AdvertMovie set AdvertMovie = @AdvertMovie where RoomId = @RoomId",
                    new { AdvertMovie = textBoxAdvertMovie.Text, RoomId = int.Parse(textBoxRoomId.Text) });
            } else {
                _conn.Execute("insert into AdvertMovie(RoomId, AdvertMovie) values(@RoomId, @AdvertMovie)",
                    new { RoomId = int.Parse(textBoxRoomId.Text), AdvertMovie = textBoxAdvertMovie.Text });
            }

            ShowAdvertMovies();
        }

        IDbConnection _conn = new SqlConnection(Properties.Settings.Default.DouyuConnectionString);

        private void listBoxSearchedAdverts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = listBoxSearchedAdverts.SelectedIndex;
            if (selectedIndex == -1)
                return;
            textBoxAdvertMovie.Text = listBoxSearchedAdverts.Items[selectedIndex].ToString();
        }

        void ShowAdvertMovies()
        {
            var movies = _conn.Query<dynamic>("select * from AdvertMovie");
            listBoxAdvertMovies.Items.Clear();
            foreach (var movie in movies) {
                listBoxAdvertMovies.Items.Add(string.Format("{0} - {1}", movie.RoomId, movie.AdvertMovie));
            }
        }
    }
}
