using CafeManagementSystem.DAL;
using CafeManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeManagementSystem.BLL
{
    class AccountBLL
    {
        private AccountBLL() 
        {
            
        }
        private static AccountBLL _Instance;
        public static AccountBLL Instance
        {
            get 
            {
                if (_Instance == null)
                    _Instance = new AccountBLL();
                return _Instance;
            }
            private set { }
            
        }

        public string getUserNameForLogin(string username, string password)
        {
            
            var account = ExcelHelper.Instance.getAccount(username, password);

            if (account != null)
            {
                return account.userName;
            }
            else
            {
                return null;
            }
        }

        public Account getAccountForEdit(string username)
        {
            return ExcelHelper.Instance.getAccountByUserName(username);
        }

        public void editDetailNameDisplay(string username, string nameNew) 
        {
            ExcelHelper.Instance.EditDetailName(username, nameNew);
        }

        public void EditProfile(string usernameToEdit, string nameNew, string passwordNew)
        {
            ExcelHelper.Instance.EditAccount(usernameToEdit, nameNew, passwordNew);
        }

        
    }
}
