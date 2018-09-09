namespace Douyu.src
{
    partial class AppSettingPanel
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
            this.splitContainerAppSettings = new System.Windows.Forms.SplitContainer();
            this.listBoxAppSettings = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelSettingRemark = new System.Windows.Forms.Label();
            this.textBoxSettingValue = new System.Windows.Forms.TextBox();
            this.labelSettingName = new System.Windows.Forms.Label();
            this.buttonRefreshSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAppSettings)).BeginInit();
            this.splitContainerAppSettings.Panel1.SuspendLayout();
            this.splitContainerAppSettings.Panel2.SuspendLayout();
            this.splitContainerAppSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerAppSettings
            // 
            this.splitContainerAppSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAppSettings.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAppSettings.Name = "splitContainerAppSettings";
            this.splitContainerAppSettings.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAppSettings.Panel1
            // 
            this.splitContainerAppSettings.Panel1.Controls.Add(this.listBoxAppSettings);
            // 
            // splitContainerAppSettings.Panel2
            // 
            this.splitContainerAppSettings.Panel2.Controls.Add(this.buttonRefreshSettings);
            this.splitContainerAppSettings.Panel2.Controls.Add(this.labelSettingName);
            this.splitContainerAppSettings.Panel2.Controls.Add(this.buttonSave);
            this.splitContainerAppSettings.Panel2.Controls.Add(this.labelSettingRemark);
            this.splitContainerAppSettings.Panel2.Controls.Add(this.textBoxSettingValue);
            this.splitContainerAppSettings.Size = new System.Drawing.Size(952, 527);
            this.splitContainerAppSettings.SplitterDistance = 434;
            this.splitContainerAppSettings.TabIndex = 1;
            // 
            // listBoxAppSettings
            // 
            this.listBoxAppSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAppSettings.FormattingEnabled = true;
            this.listBoxAppSettings.Location = new System.Drawing.Point(0, 0);
            this.listBoxAppSettings.Name = "listBoxAppSettings";
            this.listBoxAppSettings.Size = new System.Drawing.Size(952, 434);
            this.listBoxAppSettings.TabIndex = 0;
            this.listBoxAppSettings.SelectedIndexChanged += new System.EventHandler(this.listBoxAppSettings_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(613, 32);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "修改";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelSettingRemark
            // 
            this.labelSettingRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSettingRemark.Location = new System.Drawing.Point(3, 62);
            this.labelSettingRemark.Name = "labelSettingRemark";
            this.labelSettingRemark.Size = new System.Drawing.Size(604, 23);
            this.labelSettingRemark.TabIndex = 1;
            // 
            // textBoxSettingValue
            // 
            this.textBoxSettingValue.Location = new System.Drawing.Point(3, 35);
            this.textBoxSettingValue.Name = "textBoxSettingValue";
            this.textBoxSettingValue.Size = new System.Drawing.Size(604, 20);
            this.textBoxSettingValue.TabIndex = 0;
            // 
            // labelSettingName
            // 
            this.labelSettingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSettingName.Location = new System.Drawing.Point(3, 7);
            this.labelSettingName.Name = "labelSettingName";
            this.labelSettingName.Size = new System.Drawing.Size(602, 23);
            this.labelSettingName.TabIndex = 3;
            // 
            // buttonRefreshSettings
            // 
            this.buttonRefreshSettings.Location = new System.Drawing.Point(874, 32);
            this.buttonRefreshSettings.Name = "buttonRefreshSettings";
            this.buttonRefreshSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshSettings.TabIndex = 4;
            this.buttonRefreshSettings.Text = "刷新设置";
            this.buttonRefreshSettings.UseVisualStyleBackColor = true;
            // 
            // AppSettingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerAppSettings);
            this.Name = "AppSettingPanel";
            this.Size = new System.Drawing.Size(952, 527);
            this.Load += new System.EventHandler(this.AppSettingPanel_Load);
            this.splitContainerAppSettings.Panel1.ResumeLayout(false);
            this.splitContainerAppSettings.Panel2.ResumeLayout(false);
            this.splitContainerAppSettings.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAppSettings)).EndInit();
            this.splitContainerAppSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerAppSettings;
        private System.Windows.Forms.ListBox listBoxAppSettings;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelSettingRemark;
        private System.Windows.Forms.TextBox textBoxSettingValue;
        private System.Windows.Forms.Label labelSettingName;
        private System.Windows.Forms.Button buttonRefreshSettings;
    }
}
