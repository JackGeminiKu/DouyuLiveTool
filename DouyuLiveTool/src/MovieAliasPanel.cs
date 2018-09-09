using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Dapper;
using System.Data.SqlClient;

namespace Douyu.src
{
    public partial class MovieAliasPanel : UserControl
    {
        IDbConnection _connection = new SqlConnection(Properties.Settings.Default.DouyuConnectionString);

        public MovieAliasPanel()
        {
            InitializeComponent();
            if (Debugger.IsAttached)
                txtMovieName.Text = "功夫";
        }

        IEnumerable<dynamic> _movies;

        private void btnFindMovie_Click(object sender, EventArgs e)
        {
            if (txtMovieName.Text.Trim().Length == 0) {
                MessageBox.Show("请输入要要查找的电影", "查找电影");
                return;
            }

            var sql = string.Format("select * from Movie where MovieFile like '%{0}%'", txtMovieName.Text.Trim());
            _movies = _connection.Query<dynamic>(sql);
            lbMovies.Items.Clear();
            foreach (var movie in _movies) {
                lbMovies.Items.Add(movie.MovieFile);
            }
        }

        private void lbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMovieAliases(SelectedMovieId);
        }

        void ShowMovieAliases(int movieId)
        {
            var movieAliases = _connection.Query<dynamic>("select * from MovieAlias where MovieId = @MovieId",
                new { MovieId = movieId });

            lbMovieAliases.Items.Clear();
            foreach (var alias in movieAliases) {
                lbMovieAliases.Items.Add(alias.MovieAlias);
            }
        }

        private void btnAddMovieAlias_Click(object sender, EventArgs e)
        {
            // 别名不能为空
            if (txtMovieAlias.Text.Trim().Length == 0) {
                MessageBox.Show("别名不能为空", "检查别名");
                return;
            }

            // 别名是否已经存在?
            var count = _connection.ExecuteScalar<int>("select * from MovieAlias where MovieId = @MovieId and MovieAlias = @MovieAlias",
                new { MovieId = SelectedMovieId, MovieAlias = txtMovieAlias.Text });
            if (count != 0) {
                MessageBox.Show("该别名已经存在", "检查别名");
                return;
            }

            // 添加别名
            _connection.Execute("insert into MovieAlias(MovieId, MovieAlias) values(@MovieId, @MovieAlias)",
                new { MovieId = SelectedMovieId, MovieAlias = txtMovieAlias.Text.Trim() });

            // 更新别名显示
            ShowMovieAliases(SelectedMovieId);
        }

        int SelectedMovieId { get { return _movies.ElementAt(lbMovies.SelectedIndex).Id; } }
    }
}
