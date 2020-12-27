using ICar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Benchi : IRunable
    {
        public void GuaDang()
        {
            Console.WriteLine("奔驰挂挡");
            Console.ReadKey();
        }
        public void Run()
        {
            Console.WriteLine("奔驰跑");
            Console.ReadKey();


        }
    }
}
