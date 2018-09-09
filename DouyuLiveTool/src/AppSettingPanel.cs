using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using My.Windows.Forms;

namespace Douyu.src
{
    public partial class AppSettingPanel : UserControl
    {
        public AppSettingPanel()
        {
            InitializeComponent();
        }

        IDbConnection _conn = new SqlConnection(Properties.Settings.Default.DouyuConnectionString);

        void ShowAppSettings()
        {
            _appSettings = _conn.Query<dynamic>("select * from AppSetting");
            listBoxAppSettings.Items.Clear();
            foreach (var setting in _appSettings) {
                listBoxAppSettings.Items.Add(setting.Name + " = " + setting.Value);
            }
        }

        IEnumerable<dynamic> _appSettings;

        private void AppSettingPanel_Load(object sender, EventArgs e)
        {
            ShowAppSettings();
        }

        private void listBoxAppSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = listBoxAppSettings.SelectedIndex;
            if (selectedIndex == -1)
                return;

            var setting = _appSettings.ElementAt(selectedIndex);
            labelSettingName.Text = setting.Name;
            textBoxSettingValue.Text = setting.Value;
            labelSettingRemark.Text = setting.Remark;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var passwordBox = new PasswordBox();
            if (passwordBox.Show("确定要修改设置: " + labelSettingName.Text) == DialogResult.Cancel)
                return;
            if (passwordBox.Password != "123456") {
                MessageBox.Show("密码错误!", "修改程式设置");
                return;
            }

            _conn.Execute("update AppSetting set Value = @Value where Name = @Name",
                new { Name = labelSettingName.Text, Value = textBoxSettingValue.Text });
            ShowAppSettings();
        }
    }
}

