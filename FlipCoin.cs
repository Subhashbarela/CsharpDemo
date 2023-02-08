using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FlipCoin
    {
       
        public static void flip()
        {
            Random rnd = new Random();
           
            for(int i=0;i<4;i++)
            {
                Console.WriteLine(rnd.Next(3));//less than specifide
            }
           
        }
    }
}
