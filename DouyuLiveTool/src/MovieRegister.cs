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
        }

        private void btnRegisterMovie_Click(object sender, EventArgs e)
        {
            var newMovieCount = 0;
            var oldMovieCount = 0;
            var totalMovieCount = lbMovies.Items.Count;
            ImportNewMovies(lbMovies.Items, out newMovieCount, out oldMovieCount);
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
                lbMovies.Items.AddRange(movies.ToArray());
            } finally {
                btnRegisterMovie.Enabled = lbMovies.Items.Count > 0;
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
    }
}
