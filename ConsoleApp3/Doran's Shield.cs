using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
   
    public class Dorans_Shield : Item
    {
       
        public Dorans_Shield()
        {
            
          name = "Doran's Shield";
         
          price = 450;
            
          AddStat(Stat.HP, 80);
        }
    }
}