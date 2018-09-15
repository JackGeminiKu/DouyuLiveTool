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
            this.lbSearchedMovies = new System.Windows.Forms.ListBox();
            this.labelWarning = new System.Windows.Forms.Label();
            this.lbRegisteredMovies = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.btnSearchOldMovie = new System.Windows.Forms.Button();
            this.lblRegisterMovieCount = new System.Windows.Forms.Label();
            this.lblSearchedMovieCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterMovie
            // 
            this.btnRegisterMovie.Location = new System.Drawing.Point(371, 478);
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
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "电影路径:";
            // 
            // txtMovieFolder
            // 
            this.txtMovieFolder.Location = new System.Drawing.Point(80, 13);
            this.txtMovieFolder.Name = "txtMovieFolder";
            this.txtMovieFolder.ReadOnly = true;
            this.txtMovieFolder.Size = new System.Drawing.Size(285, 20);
            this.txtMovieFolder.TabIndex = 2;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(371, 10);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 3;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lbSearchedMovies
            // 
            this.lbSearchedMovies.FormattingEnabled = true;
            this.lbSearchedMovies.Location = new System.Drawing.Point(19, 39);
            this.lbSearchedMovies.Name = "lbSearchedMovies";
            this.lbSearchedMovies.Size = new System.Drawing.Size(427, 433);
            this.lbSearchedMovies.TabIndex = 4;
            // 
            // labelWarning
            // 
            this.labelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(242, 504);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(683, 23);
            this.labelWarning.TabIndex = 14;
            this.labelWarning.Text = "手动核对黑名单, 确保加入的电影不在黑名单中!!!";
            // 
            // lbRegisteredMovies
            // 
            this.lbRegisteredMovies.FormattingEnabled = true;
            this.lbRegisteredMovies.Location = new System.Drawing.Point(498, 39);
            this.lbRegisteredMovies.Name = "lbRegisteredMovies";
            this.lbRegisteredMovies.Size = new System.Drawing.Size(427, 433);
            this.lbRegisteredMovies.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "电影关键字:";
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(571, 13);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(273, 20);
            this.txtCondition.TabIndex = 17;
            this.txtCondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCondition_KeyPress);
            // 
            // btnSearchOldMovie
            // 
            this.btnSearchOldMovie.Location = new System.Drawing.Point(850, 10);
            this.btnSearchOldMovie.Name = "btnSearchOldMovie";
            this.btnSearchOldMovie.Size = new System.Drawing.Size(75, 23);
            this.btnSearchOldMovie.TabIndex = 18;
            this.btnSearchOldMovie.Text = "查找";
            this.btnSearchOldMovie.UseVisualStyleBackColor = true;
            this.btnSearchOldMovie.Click += new System.EventHandler(this.btnSearchOldMovie_Click);
            // 
            // lblRegisterMovieCount
            // 
            this.lblRegisterMovieCount.Location = new System.Drawing.Point(495, 481);
            this.lblRegisterMovieCount.Name = "lblRegisterMovieCount";
            this.lblRegisterMovieCount.Size = new System.Drawing.Size(430, 23);
            this.lblRegisterMovieCount.TabIndex = 19;
            // 
            // lblSearchedMovieCount
            // 
            this.lblSearchedMovieCount.Location = new System.Drawing.Point(16, 481);
            this.lblSearchedMovieCount.Name = "lblSearchedMovieCount";
            this.lblSearchedMovieCount.Size = new System.Drawing.Size(349, 23);
            this.lblSearchedMovieCount.TabIndex = 20;
            // 
            // MovieRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSearchedMovieCount);
            this.Controls.Add(this.lblRegisterMovieCount);
            this.Controls.Add(this.btnSearchOldMovie);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRegisteredMovies);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.lbSearchedMovies);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtMovieFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisterMovie);
            this.Name = "MovieRegister";
            this.Size = new System.Drawing.Size(952, 527);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.ListBox lbSearchedMovies;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.ListBox lbRegisteredMovies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Button btnSearchOldMovie;
        private System.Windows.Forms.Label lblRegisterMovieCount;
        private System.Windows.Forms.Label lblSearchedMovieCount;
    }
}
