namespace Douyu.src
{
    partial class MovieBlacklistPanel
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
            this.lbMovieBlacklist = new System.Windows.Forms.ListBox();
            this.lbMovies = new System.Windows.Forms.ListBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchedBlacklist = new System.Windows.Forms.TextBox();
            this.btnSearchBlacklist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMovieBlacklist
            // 
            this.lbMovieBlacklist.FormattingEnabled = true;
            this.lbMovieBlacklist.Location = new System.Drawing.Point(494, 50);
            this.lbMovieBlacklist.Name = "lbMovieBlacklist";
            this.lbMovieBlacklist.Size = new System.Drawing.Size(428, 459);
            this.lbMovieBlacklist.TabIndex = 9;
            this.lbMovieBlacklist.DoubleClick += new System.EventHandler(this.lbMovieBlacklist_DoubleClick);
            // 
            // lbMovies
            // 
            this.lbMovies.FormattingEnabled = true;
            this.lbMovies.Location = new System.Drawing.Point(26, 50);
            this.lbMovies.Name = "lbMovies";
            this.lbMovies.Size = new System.Drawing.Size(428, 459);
            this.lbMovies.TabIndex = 8;
            this.lbMovies.DoubleClick += new System.EventHandler(this.lbMovies_DoubleClick);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(264, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "查找";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(78, 15);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(180, 20);
            this.txtMovieName.TabIndex = 6;
            this.txtMovieName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMovieName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "电影名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "黑名单:";
            // 
            // txtSearchedBlacklist
            // 
            this.txtSearchedBlacklist.Location = new System.Drawing.Point(548, 15);
            this.txtSearchedBlacklist.Name = "txtSearchedBlacklist";
            this.txtSearchedBlacklist.Size = new System.Drawing.Size(173, 20);
            this.txtSearchedBlacklist.TabIndex = 11;
            this.txtSearchedBlacklist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchedBlacklist_KeyPress);
            // 
            // btnSearchBlacklist
            // 
            this.btnSearchBlacklist.Location = new System.Drawing.Point(727, 12);
            this.btnSearchBlacklist.Name = "btnSearchBlacklist";
            this.btnSearchBlacklist.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBlacklist.TabIndex = 12;
            this.btnSearchBlacklist.Text = "查找黑名单";
            this.btnSearchBlacklist.UseVisualStyleBackColor = true;
            this.btnSearchBlacklist.Click += new System.EventHandler(this.btnSearchBlacklist_Click);
            // 
            // MovieBlacklistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchBlacklist);
            this.Controls.Add(this.txtSearchedBlacklist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMovieBlacklist);
            this.Controls.Add(this.lbMovies);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label1);
            this.Name = "MovieBlacklistPanel";
            this.Size = new System.Drawing.Size(952, 527);
            this.Load += new System.EventHandler(this.MovieBlacklistPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMovieBlacklist;
        private System.Windows.Forms.ListBox lbMovies;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchedBlacklist;
        private System.Windows.Forms.Button btnSearchBlacklist;
    }
}
