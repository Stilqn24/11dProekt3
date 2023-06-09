using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11dProekt3
{
    public class ShoeType
    {
        public int Id { get; set; }
        public string Marka{ get; set; }
        public int Size { get; set; }

        //1:M
        public ICollection<Shoe> Shoes { get; set; }
    }
}
