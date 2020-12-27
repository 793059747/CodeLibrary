using ICar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BaoMa : IRunable
    {
        public void GuaDang()
        {
            Console.WriteLine("宝马挂挡");
            Console.ReadKey();
        }

        public void Run()
        {
            Console.WriteLine("宝马跑");
            Console.ReadKey();
        }
    }
}
