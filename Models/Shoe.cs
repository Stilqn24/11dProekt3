using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11dProekt3
{
    public class Shoe
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public int ShoeTypeId { get; set; }
        public ShoeType ShoeTypes { get; set; }
    }
}
