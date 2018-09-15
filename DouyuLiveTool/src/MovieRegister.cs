using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Dapper;
using System.Data.SqlClient;
using System.Collections;

namespace Douyu.src
{
    public partial class MovieRegister : UserControl
    {
        IDbConnection _connection = new SqlConnection(Properties.Settings.Default.DouyuConnectionString);

        public MovieRegister()
        {
            InitializeComponent();
            ShowRegisteredMovies("");
        }

        private void btnRegisterMovie_Click(object sender, EventArgs e)
        {
            var newMovieCount = 0;
            var oldMovieCount = 0;
            var totalMovieCount = lbSearchedMovies.Items.Count;
            ImportNewMovies(lbSearchedMovies.Items, out newMovieCount, out oldMovieCount);
            ShowRegisteredMovies("");
            MessageBox.Show(string.Format("一共找到电影{0}部, 其中导入新电影{1}部, 发现旧电影{2}部!",
                    totalMovieCount, newMovieCount, oldMovieCount),
                "导入电影", MessageBoxButtons.OK);
        }

        void ImportNewMovies(IList movies, out int newMovieCount, out int oldMovieCount)
        {
            newMovieCount = oldMovieCount = 0;
            foreach (var movieFile in movies) {
                var count = _connection.ExecuteScalar<int>("select count(*) from Movie where MovieFile = @MovieFile",
                    new { MovieFile = movieFile });
                if (count == 1) {
                    ++oldMovieCount;
                    continue;
                }
                var movieName = Path.GetFileNameWithoutExtension((string)movieFile);
                _connection.Execute("insert into Movie(MovieName, MovieFile) values(@MovieName, @MovieFile)",
                    new { MovieName = movieName, MovieFile = movieFile });
                ++newMovieCount;
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            try {
                this.Enabled = false;
                var folderBrowser = new FolderBrowserDialog();
                if (folderBrowser.ShowDialog() == DialogResult.Cancel)
                    return;

                txtMovieFolder.Text = folderBrowser.SelectedPath;
                var movies = SearchMovies(folderBrowser.SelectedPath);

                lbSearchedMovies.Items.Clear();
                lbSearchedMovies.Items.AddRange(movies.ToArray());
                lblSearchedMovieCount.Text = string.Format("共找到电影{0}部!",movies.Count());
            } finally {
                btnRegisterMovie.Enabled = lbSearchedMovies.Items.Count > 0;
                this.Enabled = true;
            }
        }

        List<string> SearchMovies(string directory)
        {
            List<string> movies = new List<string>();
            foreach (var dir in Directory.GetDirectories(directory)) {
                movies.AddRange(SearchMovies(dir));
            }

            foreach (var file in Directory.GetFiles(directory)) {
                if (!file.EndsWith(".mp4") && !file.EndsWith(".mkv")) {
                    MessageBox.Show("未知的电影类型: " + Path.GetExtension(file), "未知电影类型", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<string>();
                }
                movies.Add(file);
            }

            return movies;
        }

        private void btnSearchOldMovie_Click(object sender, EventArgs e)
        {
            ShowRegisteredMovies(txtCondition.Text);
        }

        void ShowRegisteredMovies(string condition)
        {
            var sql = "select * from Movie";
            if (condition.Trim().Length != 0)
                sql += string.Format(" where MovieFile like '%{0}%'", condition);
            sql += " order by MovieFile";
            var movies = _connection.Query<dynamic>(sql);

            lbRegisteredMovies.Items.Clear();
            foreach (var movie in movies) {
                lbRegisteredMovies.Items.Add(movie.MovieFile);
            }
            lblRegisterMovieCount.Text = string.Format("共有注册电影{0}部!", movies.Count());
        }

        private void txtCondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') ShowRegisteredMovies(txtCondition.Text);
        }
    }
}
