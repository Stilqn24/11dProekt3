using _11dProekt3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11dProekt3.Controler
{
    public class ShoesLogic
    {
        private ShoesContext shoesContext=new ShoesContext();
        public List<Shoe>GetALL()
        {
            using (shoesContext=new ShoesContext())
            {
                List<Shoe> listShoes = shoesContext.Shoes.ToList();
                return listShoes;
            }
        }
        public Shoe Get(int id)
        {
            using(shoesContext = new ShoesContext())
            {
                Shoe findedShoe = shoesContext.Shoes.Find(id);
                if(findedShoe != null)
                {
                    shoesContext.Entry(findedShoe).Reference(x => x.ShoeTypes).Load();
                }
                return findedShoe;
            }
            
        }
        public void Create(Shoe shoe)
        {
            using (shoesContext= new ShoesContext())
            {
            shoesContext.Shoes.Add(shoe);
                shoesContext.SaveChanges();

            }
        }
        public void Update (int id,Shoe shoe) 
        {
            using (shoesContext = new ShoesContext())
            {
                Shoe finded = shoesContext.Shoes.Find(id);
                if(finded == null)
                {
                    return;
                }
                
            }
        }
        
    }
}

