using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.DTO
{
    internal class TableFood
    {
        private int id { get; set; }
        private string name { get; set; }
        private string status { get; set; }

        public TableFood(int id, string name, string status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }
    }
}
