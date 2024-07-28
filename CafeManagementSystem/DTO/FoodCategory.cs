using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.DTO
{
    internal class FoodCategory
    {
        private int id { get; set; }
        private string name { get; set; }

        public FoodCategory(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
