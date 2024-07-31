using CafeManagementSystem.BLL;
using CafeManagementSystem.DAL;
using CafeManagementSystem.DTO;
using CafeManagementSystem.GUI;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        

        

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text.ToString().Trim();
            string password = txbPassWord.Text.ToString().Trim();
            
            string result = AccountBLL.Instance.getUserNameForLogin(username, password);
            if(result != null)
            {
                TableManager f = new TableManager(result);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
            
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExcelHelper.Instance.updateToDatabaseWhenAppClose();
        }
    }
}
