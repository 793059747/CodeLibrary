using ICar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Aodi : IRunable
    {
        public void GuaDang()
        {
            Console.WriteLine("奥迪挂挡");
            Console.ReadKey();
        }

        public void Run()
        {
            Console.WriteLine("奥迪跑");
            Console.ReadKey();
        }
    }
}
