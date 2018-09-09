namespace Douyu
{
    partial class MianForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpRegisterMovie = new System.Windows.Forms.TabPage();
            this.tpMovieAlias = new System.Windows.Forms.TabPage();
            this.tpMovieBlacklist = new System.Windows.Forms.TabPage();
            this.tpRoomMovie = new System.Windows.Forms.TabPage();
            this.tpAppSettings = new System.Windows.Forms.TabPage();
            this.newMoviePanel1 = new Douyu.src.MovieRegister();
            this.roomMoviePanel1 = new Douyu.src.RoomMoviePanel();
            this.movieAliasPanel1 = new Douyu.src.MovieAliasPanel();
            this.movieBlacklistPanel1 = new Douyu.src.MovieBlacklistPanel();
            this.appSettingPanel1 = new Douyu.src.AppSettingPanel();
            this.tabControl.SuspendLayout();
            this.tpRegisterMovie.SuspendLayout();
            this.tpMovieAlias.SuspendLayout();
            this.tpMovieBlacklist.SuspendLayout();
            this.tpRoomMovie.SuspendLayout();
            this.tpAppSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tpRegisterMovie);
            this.tabControl.Controls.Add(this.tpRoomMovie);
            this.tabControl.Controls.Add(this.tpMovieAlias);
            this.tabControl.Controls.Add(this.tpMovieBlacklist);
            this.tabControl.Controls.Add(this.tpAppSettings);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(960, 556);
            this.tabControl.TabIndex = 4;
            // 
            // tpRegisterMovie
            // 
            this.tpRegisterMovie.Controls.Add(this.newMoviePanel1);
            this.tpRegisterMovie.Location = new System.Drawing.Point(4, 25);
            this.tpRegisterMovie.Name = "tpRegisterMovie";
            this.tpRegisterMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegisterMovie.Size = new System.Drawing.Size(952, 527);
            this.tpRegisterMovie.TabIndex = 0;
            this.tpRegisterMovie.Text = "注册新电影";
            this.tpRegisterMovie.UseVisualStyleBackColor = true;
            // 
            // tpMovieAlias
            // 
            this.tpMovieAlias.Controls.Add(this.movieAliasPanel1);
            this.tpMovieAlias.Location = new System.Drawing.Point(4, 25);
            this.tpMovieAlias.Name = "tpMovieAlias";
            this.tpMovieAlias.Padding = new System.Windows.Forms.Padding(3);
            this.tpMovieAlias.Size = new System.Drawing.Size(952, 527);
            this.tpMovieAlias.TabIndex = 1;
            this.tpMovieAlias.Text = "电影别名";
            this.tpMovieAlias.UseVisualStyleBackColor = true;
            // 
            // tpMovieBlacklist
            // 
            this.tpMovieBlacklist.Controls.Add(this.movieBlacklistPanel1);
            this.tpMovieBlacklist.Location = new System.Drawing.Point(4, 25);
            this.tpMovieBlacklist.Name = "tpMovieBlacklist";
            this.tpMovieBlacklist.Padding = new System.Windows.Forms.Padding(3);
            this.tpMovieBlacklist.Size = new System.Drawing.Size(952, 527);
            this.tpMovieBlacklist.TabIndex = 2;
            this.tpMovieBlacklist.Text = "电影黑名单";
            this.tpMovieBlacklist.UseVisualStyleBackColor = true;
            // 
            // tpRoomMovie
            // 
            this.tpRoomMovie.Controls.Add(this.roomMoviePanel1);
            this.tpRoomMovie.Location = new System.Drawing.Point(4, 25);
            this.tpRoomMovie.Name = "tpRoomMovie";
            this.tpRoomMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoomMovie.Size = new System.Drawing.Size(952, 527);
            this.tpRoomMovie.TabIndex = 3;
            this.tpRoomMovie.Text = "房间电影";
            this.tpRoomMovie.UseVisualStyleBackColor = true;
            // 
            // tpAppSettings
            // 
            this.tpAppSettings.Controls.Add(this.appSettingPanel1);
            this.tpAppSettings.Location = new System.Drawing.Point(4, 25);
            this.tpAppSettings.Name = "tpAppSettings";
            this.tpAppSettings.Size = new System.Drawing.Size(952, 527);
            this.tpAppSettings.TabIndex = 4;
            this.tpAppSettings.Text = "程式设置";
            this.tpAppSettings.UseVisualStyleBackColor = true;
            // 
            // newMoviePanel1
            // 
            this.newMoviePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMoviePanel1.Location = new System.Drawing.Point(3, 3);
            this.newMoviePanel1.Name = "newMoviePanel1";
            this.newMoviePanel1.Size = new System.Drawing.Size(946, 521);
            this.newMoviePanel1.TabIndex = 0;
            // 
            // roomMoviePanel1
            // 
            this.roomMoviePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomMoviePanel1.Location = new System.Drawing.Point(3, 3);
            this.roomMoviePanel1.Name = "roomMoviePanel1";
            this.roomMoviePanel1.Size = new System.Drawing.Size(946, 521);
            this.roomMoviePanel1.TabIndex = 0;
            // 
            // movieAliasPanel1
            // 
            this.movieAliasPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieAliasPanel1.Location = new System.Drawing.Point(3, 3);
            this.movieAliasPanel1.Name = "movieAliasPanel1";
            this.movieAliasPanel1.Size = new System.Drawing.Size(946, 521);
            this.movieAliasPanel1.TabIndex = 0;
            // 
            // movieBlacklistPanel1
            // 
            this.movieBlacklistPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieBlacklistPanel1.Location = new System.Drawing.Point(3, 3);
            this.movieBlacklistPanel1.Name = "movieBlacklistPanel1";
            this.movieBlacklistPanel1.Size = new System.Drawing.Size(946, 521);
            this.movieBlacklistPanel1.TabIndex = 0;
            // 
            // appSettingPanel1
            // 
            this.appSettingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appSettingPanel1.Location = new System.Drawing.Point(0, 0);
            this.appSettingPanel1.Name = "appSettingPanel1";
            this.appSettingPanel1.Size = new System.Drawing.Size(952, 527);
            this.appSettingPanel1.TabIndex = 0;
            // 
            // MianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 580);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "MianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Douyu Live Tool";
            this.tabControl.ResumeLayout(false);
            this.tpRegisterMovie.ResumeLayout(false);
            this.tpMovieAlias.ResumeLayout(false);
            this.tpMovieBlacklist.ResumeLayout(false);
            this.tpRoomMovie.ResumeLayout(false);
            this.tpAppSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpRegisterMovie;
        private System.Windows.Forms.TabPage tpMovieAlias;
        private System.Windows.Forms.TabPage tpMovieBlacklist;
        private System.Windows.Forms.TabPage tpRoomMovie;
        private src.MovieRegister newMoviePanel1;
        private src.MovieAliasPanel movieAliasPanel1;
        private src.MovieBlacklistPanel movieBlacklistPanel1;
        private src.RoomMoviePanel roomMoviePanel1;
        private System.Windows.Forms.TabPage tpAppSettings;
        private src.AppSettingPanel appSettingPanel1;
    }
}

