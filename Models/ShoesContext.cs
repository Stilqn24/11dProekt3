using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11dProekt3.Models
{
    public class ShoesContext:DbContext
    {
      public ShoesContext() : base("ShoesContext")
       {
        
       }
       public DbSet<Shoe> Shoes { get; set; }
       public DbSet<ShoeType>ShoeTypes { get; set; }

    }
}
