namespace Douyu.src
{
    partial class MovieAliasPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMovieAliases = new System.Windows.Forms.ListBox();
            this.btnAddMovieAlias = new System.Windows.Forms.Button();
            this.txtAliasName = new System.Windows.Forms.TextBox();
            this.lbMovies = new System.Windows.Forms.ListBox();
            this.btnFindMovie = new System.Windows.Forms.Button();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMovieAliasList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbMovieAliases
            // 
            this.lbMovieAliases.FormattingEnabled = true;
            this.lbMovieAliases.Location = new System.Drawing.Point(90, 285);
            this.lbMovieAliases.Name = "lbMovieAliases";
            this.lbMovieAliases.Size = new System.Drawing.Size(439, 199);
            this.lbMovieAliases.TabIndex = 13;
            // 
            // btnAddMovieAlias
            // 
            this.btnAddMovieAlias.Location = new System.Drawing.Point(317, 253);
            this.btnAddMovieAlias.Name = "btnAddMovieAlias";
            this.btnAddMovieAlias.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovieAlias.TabIndex = 12;
            this.btnAddMovieAlias.Text = "添加别名";
            this.btnAddMovieAlias.UseVisualStyleBackColor = true;
            this.btnAddMovieAlias.Click += new System.EventHandler(this.btnAddMovieAlias_Click);
            // 
            // txtAliasName
            // 
            this.txtAliasName.Location = new System.Drawing.Point(90, 256);
            this.txtAliasName.Name = "txtAliasName";
            this.txtAliasName.Size = new System.Drawing.Size(198, 20);
            this.txtAliasName.TabIndex = 11;
            // 
            // lbMovies
            // 
            this.lbMovies.FormattingEnabled = true;
            this.lbMovies.Location = new System.Drawing.Point(90, 45);
            this.lbMovies.Name = "lbMovies";
            this.lbMovies.Size = new System.Drawing.Size(439, 199);
            this.lbMovies.TabIndex = 10;
            this.lbMovies.SelectedIndexChanged += new System.EventHandler(this.lbMovies_SelectedIndexChanged);
            // 
            // btnFindMovie
            // 
            this.btnFindMovie.Location = new System.Drawing.Point(317, 13);
            this.btnFindMovie.Name = "btnFindMovie";
            this.btnFindMovie.Size = new System.Drawing.Size(75, 23);
            this.btnFindMovie.TabIndex = 9;
            this.btnFindMovie.Text = "查找";
            this.btnFindMovie.UseVisualStyleBackColor = true;
            this.btnFindMovie.Click += new System.EventHandler(this.btnFindMovie_Click);
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(90, 16);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(198, 20);
            this.txtMovieName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "电影名字";
            // 
            // lbMovieAliasList
            // 
            this.lbMovieAliasList.FormattingEnabled = true;
            this.lbMovieAliasList.Location = new System.Drawing.Point(559, 45);
            this.lbMovieAliasList.Name = "lbMovieAliasList";
            this.lbMovieAliasList.Size = new System.Drawing.Size(368, 446);
            this.lbMovieAliasList.TabIndex = 14;
            // 
            // MovieAliasPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbMovieAliasList);
            this.Controls.Add(this.lbMovieAliases);
            this.Controls.Add(this.btnAddMovieAlias);
            this.Controls.Add(this.txtAliasName);
            this.Controls.Add(this.lbMovies);
            this.Controls.Add(this.btnFindMovie);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label1);
            this.Name = "MovieAliasPanel";
            this.Size = new System.Drawing.Size(952, 527);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMovieAliases;
        private System.Windows.Forms.Button btnAddMovieAlias;
        private System.Windows.Forms.TextBox txtAliasName;
        private System.Windows.Forms.ListBox lbMovies;
        private System.Windows.Forms.Button btnFindMovie;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMovieAliasList;
    }
}
