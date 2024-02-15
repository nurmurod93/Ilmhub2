using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilmhub2
{
    public class Car
    {   
        public const int MaxSped = 550;
        public readonly string Brend = "Marsaxod";
        public Car()
        {
            const int MaxSped = 550;
            Console.WriteLine(Brend);
            Console.WriteLine(MaxSped);
        }
    }
}
