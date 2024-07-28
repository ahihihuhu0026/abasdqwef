using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.DTO
{
    internal class Food
    {
        private int id { get; set; }
        private string name { get; set; }
        private int idCategory { get; set; }

        private float price { get; set; }

        public Food(int id, string name, int idCategory, float price)
        {
            this.id = id;
            this.name = name;
            this.idCategory = idCategory;
            this.price = price;
        }
    }
}
