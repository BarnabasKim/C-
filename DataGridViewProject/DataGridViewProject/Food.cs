using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewProject
{
   public class Food
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public Food(string type, string name)
        {
            Type = type;
            Name = name;
        }
    }


}
