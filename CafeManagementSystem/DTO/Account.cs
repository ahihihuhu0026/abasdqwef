using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.DTO
{
    internal class Account
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int Type { get; set; }

        public Account(int id, string displayName, string userName, string passWord, int type)
        {
            Id = id;
            DisplayName = displayName;
            UserName = userName;
            PassWord = passWord;
            Type = type;
        }
    }
}
