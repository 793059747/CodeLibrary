using ICar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ZhongHua : IRunable
    {
        public void GuaDang()
        {
            Console.WriteLine("中华车挂挡");
            Console.ReadKey();
        }

        public void Run()
        {
            Console.WriteLine("中华车跑");
            Console.ReadKey();
        }
    }
}
