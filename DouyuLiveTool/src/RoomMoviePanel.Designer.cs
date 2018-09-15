namespace Douyu.src
{
    partial class RoomMoviePanel
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
            this.btnDeleteRoomMovies = new System.Windows.Forms.Button();
            this.btnAddMoviesToRoom = new System.Windows.Forms.Button();
            this.btnShowSearchedMovies = new System.Windows.Forms.Button();
            this.txtSearchedMovie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSearchedMovies = new System.Windows.Forms.ListBox();
            this.lbRoomMovies = new System.Windows.Forms.ListBox();
            this.btnShowRoomMovies = new System.Windows.Forms.Button();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRoomMovieCount = new System.Windows.Forms.Label();
            this.lblSearchedMovieCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteRoomMovies
            // 
            this.btnDeleteRoomMovies.Location = new System.Drawing.Point(363, 11);
            this.btnDeleteRoomMovies.Name = "btnDeleteRoomMovies";
            this.btnDeleteRoomMovies.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteRoomMovies.TabIndex = 19;
            this.btnDeleteRoomMovies.Text = "删除房间电影";
            this.btnDeleteRoomMovies.UseVisualStyleBackColor = true;
            this.btnDeleteRoomMovies.Click += new System.EventHandler(this.btnDeleteRoomMovies_Click);
            // 
            // btnAddMoviesToRoom
            // 
            this.btnAddMoviesToRoom.Location = new System.Drawing.Point(839, 11);
            this.btnAddMoviesToRoom.Name = "btnAddMoviesToRoom";
            this.btnAddMoviesToRoom.Size = new System.Drawing.Size(98, 23);
            this.btnAddMoviesToRoom.TabIndex = 18;
            this.btnAddMoviesToRoom.Text = "添加到房间";
            this.btnAddMoviesToRoom.UseVisualStyleBackColor = true;
            this.btnAddMoviesToRoom.Click += new System.EventHandler(this.btnAddMoviesToRoom_Click);
            // 
            // btnShowSearchedMovies
            // 
            this.btnShowSearchedMovies.Location = new System.Drawing.Point(758, 11);
            this.btnShowSearchedMovies.Name = "btnShowSearchedMovies";
            this.btnShowSearchedMovies.Size = new System.Drawing.Size(75, 23);
            this.btnShowSearchedMovies.TabIndex = 17;
            this.btnShowSearchedMovies.Text = "查询";
            this.btnShowSearchedMovies.UseVisualStyleBackColor = true;
            this.btnShowSearchedMovies.Click += new System.EventHandler(this.btnShowSearchedMovies_Click);
            // 
            // txtSearchedMovie
            // 
            this.txtSearchedMovie.Location = new System.Drawing.Point(549, 13);
            this.txtSearchedMovie.Name = "txtSearchedMovie";
            this.txtSearchedMovie.Size = new System.Drawing.Size(203, 20);
            this.txtSearchedMovie.TabIndex = 16;
            this.txtSearchedMovie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchedMovie_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "电影关键字";
            // 
            // lbSearchedMovies
            // 
            this.lbSearchedMovies.FormattingEnabled = true;
            this.lbSearchedMovies.Location = new System.Drawing.Point(490, 42);
            this.lbSearchedMovies.Name = "lbSearchedMovies";
            this.lbSearchedMovies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSearchedMovies.Size = new System.Drawing.Size(447, 446);
            this.lbSearchedMovies.TabIndex = 14;
            // 
            // lbRoomMovies
            // 
            this.lbRoomMovies.FormattingEnabled = true;
            this.lbRoomMovies.Location = new System.Drawing.Point(14, 42);
            this.lbRoomMovies.Name = "lbRoomMovies";
            this.lbRoomMovies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbRoomMovies.Size = new System.Drawing.Size(447, 446);
            this.lbRoomMovies.TabIndex = 13;
            // 
            // btnShowRoomMovies
            // 
            this.btnShowRoomMovies.Location = new System.Drawing.Point(282, 13);
            this.btnShowRoomMovies.Name = "btnShowRoomMovies";
            this.btnShowRoomMovies.Size = new System.Drawing.Size(75, 23);
            this.btnShowRoomMovies.TabIndex = 12;
            this.btnShowRoomMovies.Text = "查询";
            this.btnShowRoomMovies.UseVisualStyleBackColor = true;
            this.btnShowRoomMovies.Click += new System.EventHandler(this.btnShowRoomMovies_Click);
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(61, 16);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(215, 20);
            this.txtRoomId.TabIndex = 11;
            this.txtRoomId.Text = "742805";
            this.txtRoomId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "房间号:";
            // 
            // lblRoomMovieCount
            // 
            this.lblRoomMovieCount.Location = new System.Drawing.Point(16, 497);
            this.lblRoomMovieCount.Name = "lblRoomMovieCount";
            this.lblRoomMovieCount.Size = new System.Drawing.Size(445, 23);
            this.lblRoomMovieCount.TabIndex = 20;
            // 
            // lblSearchedMovieCount
            // 
            this.lblSearchedMovieCount.Location = new System.Drawing.Point(487, 497);
            this.lblSearchedMovieCount.Name = "lblSearchedMovieCount";
            this.lblSearchedMovieCount.Size = new System.Drawing.Size(450, 23);
            this.lblSearchedMovieCount.TabIndex = 21;
            // 
            // RoomMoviePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSearchedMovieCount);
            this.Controls.Add(this.lblRoomMovieCount);
            this.Controls.Add(this.btnDeleteRoomMovies);
            this.Controls.Add(this.btnAddMoviesToRoom);
            this.Controls.Add(this.btnShowSearchedMovies);
            this.Controls.Add(this.txtSearchedMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSearchedMovies);
            this.Controls.Add(this.lbRoomMovies);
            this.Controls.Add(this.btnShowRoomMovies);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.label1);
            this.Name = "RoomMoviePanel";
            this.Size = new System.Drawing.Size(952, 527);
            this.Load += new System.EventHandler(this.RoomMoviePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRoomMovies;
        private System.Windows.Forms.Button btnAddMoviesToRoom;
        private System.Windows.Forms.Button btnShowSearchedMovies;
        private System.Windows.Forms.TextBox txtSearchedMovie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSearchedMovies;
        private System.Windows.Forms.ListBox lbRoomMovies;
        private System.Windows.Forms.Button btnShowRoomMovies;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRoomMovieCount;
        private System.Windows.Forms.Label lblSearchedMovieCount;
    }
}
