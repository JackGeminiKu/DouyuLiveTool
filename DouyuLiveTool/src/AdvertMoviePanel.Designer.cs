namespace Douyu.src
{
    partial class AdvertMoviePanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdvertDirectory = new System.Windows.Forms.TextBox();
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.listBoxSearchedAdverts = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRoomId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAdvertMovie = new System.Windows.Forms.TextBox();
            this.buttonSaveAsRoomAdvert = new System.Windows.Forms.Button();
            this.listBoxAdvertMovies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "广告路径:";
            // 
            // textBoxAdvertDirectory
            // 
            this.textBoxAdvertDirectory.Location = new System.Drawing.Point(81, 13);
            this.textBoxAdvertDirectory.Name = "textBoxAdvertDirectory";
            this.textBoxAdvertDirectory.ReadOnly = true;
            this.textBoxAdvertDirectory.Size = new System.Drawing.Size(338, 20);
            this.textBoxAdvertDirectory.TabIndex = 1;
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Location = new System.Drawing.Point(425, 10);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectDirectory.TabIndex = 2;
            this.buttonSelectDirectory.Text = "...";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.buttonSelectDirectory_Click);
            // 
            // listBoxSearchedAdverts
            // 
            this.listBoxSearchedAdverts.FormattingEnabled = true;
            this.listBoxSearchedAdverts.Location = new System.Drawing.Point(81, 43);
            this.listBoxSearchedAdverts.Name = "listBoxSearchedAdverts";
            this.listBoxSearchedAdverts.Size = new System.Drawing.Size(419, 407);
            this.listBoxSearchedAdverts.TabIndex = 3;
            this.listBoxSearchedAdverts.SelectedIndexChanged += new System.EventHandler(this.listBoxSearchedAdverts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "房间号:";
            // 
            // textBoxRoomId
            // 
            this.textBoxRoomId.Location = new System.Drawing.Point(129, 472);
            this.textBoxRoomId.Name = "textBoxRoomId";
            this.textBoxRoomId.Size = new System.Drawing.Size(256, 20);
            this.textBoxRoomId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "广告:";
            // 
            // textBoxAdvertMovie
            // 
            this.textBoxAdvertMovie.Location = new System.Drawing.Point(129, 499);
            this.textBoxAdvertMovie.Name = "textBoxAdvertMovie";
            this.textBoxAdvertMovie.ReadOnly = true;
            this.textBoxAdvertMovie.Size = new System.Drawing.Size(256, 20);
            this.textBoxAdvertMovie.TabIndex = 7;
            // 
            // buttonSaveAsRoomAdvert
            // 
            this.buttonSaveAsRoomAdvert.Location = new System.Drawing.Point(414, 472);
            this.buttonSaveAsRoomAdvert.Name = "buttonSaveAsRoomAdvert";
            this.buttonSaveAsRoomAdvert.Size = new System.Drawing.Size(116, 47);
            this.buttonSaveAsRoomAdvert.TabIndex = 8;
            this.buttonSaveAsRoomAdvert.Text = "设为房间广告";
            this.buttonSaveAsRoomAdvert.UseVisualStyleBackColor = true;
            this.buttonSaveAsRoomAdvert.Click += new System.EventHandler(this.buttonSaveAsRoomAdvert_Click);
            // 
            // listBoxAdvertMovies
            // 
            this.listBoxAdvertMovies.FormattingEnabled = true;
            this.listBoxAdvertMovies.Location = new System.Drawing.Point(512, 43);
            this.listBoxAdvertMovies.Name = "listBoxAdvertMovies";
            this.listBoxAdvertMovies.Size = new System.Drawing.Size(419, 407);
            this.listBoxAdvertMovies.TabIndex = 9;
            // 
            // AdvertMoviePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxAdvertMovies);
            this.Controls.Add(this.buttonSaveAsRoomAdvert);
            this.Controls.Add(this.textBoxAdvertMovie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRoomId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxSearchedAdverts);
            this.Controls.Add(this.buttonSelectDirectory);
            this.Controls.Add(this.textBoxAdvertDirectory);
            this.Controls.Add(this.label1);
            this.Name = "AdvertMoviePanel";
            this.Size = new System.Drawing.Size(952, 527);
            this.Load += new System.EventHandler(this.AdvertMoviePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdvertDirectory;
        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.ListBox listBoxSearchedAdverts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRoomId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAdvertMovie;
        private System.Windows.Forms.Button buttonSaveAsRoomAdvert;
        private System.Windows.Forms.ListBox listBoxAdvertMovies;
    }
}
