using CafeManagementSystem.DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CafeManagementSystem.DAL
{
    class ExcelHelper
    {
        private List<Account> accounts;
        private string filePath = "DATABASE.XLSX";

        private static ExcelHelper _Instance;
        public static ExcelHelper Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ExcelHelper();
                return _Instance;

            }
            private set { }
        }
        

        private ExcelHelper()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            this.accounts = LoadAccountData();
        }

        private void updateSheetAccount()
        {
            string sheetName = "Account";
            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                // Lấy sheet theo tên hoặc tạo mới nếu không tồn tại
                var sheet = package.Workbook.Worksheets[sheetName] ?? package.Workbook.Worksheets.Add(sheetName);

                // Ghi tiêu đề
                sheet.Cells[1, 1].Value = "Id";
                sheet.Cells[1, 2].Value = "DisplayName";
                sheet.Cells[1, 3].Value = "UserName";
                sheet.Cells[1, 4].Value = "Password";
                sheet.Cells[1, 5].Value = "Type";

                // Ghi dữ liệu
                for (int i = 0; i < accounts.Count; i++)
                {
                    var acc = accounts[i];
                    sheet.Cells[i + 2, 1].Value = acc.Id;
                    sheet.Cells[i + 2, 2].Value = acc.DisplayName;
                    sheet.Cells[i + 2, 3].Value = acc.UserName;
                    sheet.Cells[i + 2, 4].Value = acc.PassWord;
                    sheet.Cells[i + 2, 5].Value = acc.Type;
                }

                // Lưu file
                package.Save();
            }
        }

        public void updateToDatabaseWhenAppClose()
        {
            updateSheetAccount();
        }

        


        public List<Account> LoadAccountData()
        {
            
            string sheetName = "Account";
            var listAccounts = new List<Account>();
            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                // Lấy sheet theo tên
                var sheet = package.Workbook.Worksheets[sheetName];
                if (sheet == null)
                {
                    MessageBox.Show($"Sheet '{sheetName}' không tồn tại.");
                    return null;
                }

                int rowCount = sheet.Dimension.Rows;
                int colCount = sheet.Dimension.Columns;

                for (int row = 2; row <= rowCount; row++)
                {
                    var acc = new Account
                    (int.Parse(sheet.Cells[row, 1].Text),
                        sheet.Cells[row, 2].Text,
                        sheet.Cells[row, 3].Text,
                        sheet.Cells[row, 4].Text,
                        int.Parse(sheet.Cells[row, 5].Text));
                    listAccounts.Add(acc);
                }
            }

            // In dữ liệu ra màn hình
            return listAccounts;
        }


        public Account getAccount(string username, string password)
        {
            return accounts.FirstOrDefault(a => a.UserName == username && a.PassWord == password);
        }

        public Account getAccountByUserName(string username)
        {
            return accounts.FirstOrDefault(a => a.UserName == username);
        }

        public void EditDetailName(string usernameToEdit, string nameDisplayNew)
        {
            var accountToEdit = accounts.FirstOrDefault(a => a.UserName == usernameToEdit);

            if (accountToEdit != null)
            {
                accountToEdit.DisplayName = nameDisplayNew;
            }
        }

        public void EditAccount(string usernameToEdit, string nameNew, string passwordNew)
        {
            var accountToEdit = accounts.FirstOrDefault(a => a.UserName == usernameToEdit);
            if (accountToEdit != null)
            {
                accountToEdit.DisplayName = nameNew;
                accountToEdit.PassWord = passwordNew;
            }
        }


    }
}
