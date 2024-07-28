using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.DTO
{
    internal class Bill
    {
        private int id { get; set; }
        private DateTime dateCheckIn { get; set; }

        private DateTime? dateCheckOut { get; set; }

        private int idTable { get; set; }

        private int status { get; set; }

        public Bill(int id, DateTime dateCheckIn, DateTime? dateCheckOut, int idTable, int status)
        {
            this.id = id;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.idTable = idTable;
            this.status = status;
        }
    }
}
