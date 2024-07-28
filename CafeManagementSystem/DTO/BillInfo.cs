using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.DTO
{
    internal class BillInfo
    {
        private int id { get; set; }
        private int idBill { get; set; }
        private int idFood { get; set; }
        private int count { get; set; }

        public BillInfo(int id, int idBill, int idFood, int count)
        {
            this.id = id;
            this.idBill = idBill;
            this.idFood = idFood;
            this.count = count;
        }
    }
}
