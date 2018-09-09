namespace Douyu.src
{
    partial class MovieRegister
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
            this.btnRegisterMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieFolder = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lbMovies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRegisterMovie
            // 
            this.btnRegisterMovie.Location = new System.Drawing.Point(683, 443);
            this.btnRegisterMovie.Name = "btnRegisterMovie";
            this.btnRegisterMovie.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterMovie.TabIndex = 0;
            this.btnRegisterMovie.Text = "注册新电影";
            this.btnRegisterMovie.UseVisualStyleBackColor = true;
            this.btnRegisterMovie.Click += new System.EventHandler(this.btnRegisterMovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "电影路径:";
            // 
            // txtMovieFolder
            // 
            this.txtMovieFolder.Location = new System.Drawing.Point(90, 13);
            this.txtMovieFolder.Name = "txtMovieFolder";
            this.txtMovieFolder.Size = new System.Drawing.Size(587, 20);
            this.txtMovieFolder.TabIndex = 2;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(683, 10);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 3;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lbMovies
            // 
            this.lbMovies.FormattingEnabled = true;
            this.lbMovies.Location = new System.Drawing.Point(90, 39);
            this.lbMovies.Name = "lbMovies";
            this.lbMovies.Size = new System.Drawing.Size(668, 394);
            this.lbMovies.TabIndex = 4;
            // 
            // MovieRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbMovies);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtMovieFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisterMovie);
            this.Name = "MovieRegister";
            this.Size = new System.Drawing.Size(783, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.ListBox lbMovies;
    }
}
