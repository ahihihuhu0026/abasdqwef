using CafeManagementSystem.BLL;
using CafeManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem.GUI
{
    partial class AccountProfile : Form
    {
        public AccountProfile()
        {
            InitializeComponent();
        }
        public AccountProfile(string username)
        {
            InitializeComponent();
            InitView(username);
        }

        private void InitView(string username)
        {
            var account = AccountBLL.Instance.getAccountForEdit(username);
            //txbDisplayName.Text = account.DisplayName;
            txbUserName.Text = username;
            txbDisplayName.Text = account.DisplayName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string txtUserName = txbUserName.Text.Trim().ToString();
            string txtDisplayName = txbDisplayName.Text.Trim().ToString();
            string txtPassword = txbPassWord.Text.Trim().ToString();
            if(txtPassword.Length == 0 )
            {
                //only edit namedisplay
                AccountBLL.Instance.editDetailNameDisplay(txtUserName, txtDisplayName);
                MessageBox.Show("Cập nhật tên thành công");
            }
            else
            {
                //edit password
                string passwordNew = txbNewPass.Text.Trim().ToString();
                string re_enterPass = txbReEnterPass.Text.Trim().ToString();
                if(passwordNew.Length != 0 && passwordNew == re_enterPass)
                {
                    string username = AccountBLL.Instance.getUserNameForLogin(txtUserName, txtPassword);
                    if(username != "")
                    {
                        //allow edit
                        AccountBLL.Instance.EditProfile(txtUserName, txtDisplayName, passwordNew);
                        MessageBox.Show("Thành công");

                    }
                    else
                    {
                        //pass incorrect
                        MessageBox.Show("Mật khẩu cũ không đúng");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp");
                }
                
            }
        }
    }
}
