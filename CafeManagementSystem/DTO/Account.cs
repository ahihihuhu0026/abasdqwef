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
        public int id { get; set; }
        public string displayName { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public int type { get; set; }

        public Account(int id, string displayName, string userName, string passWord, int type)
        {
            this.id = id;
            this.displayName = displayName;
            this.userName = userName;
            this.passWord = passWord;
            this.type = type;
        }
    }
}
