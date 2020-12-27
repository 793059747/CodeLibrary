using ClassLibrary;
using ICar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCar
{
    public class Boss
    {  
        /// <summary>
        /// 简单工厂-基础实现r
        /// </summary>
        /// <param name="carenum"></param>
        public void UseCar(carenum carenum)
        {
            IRunable runable = null;
            switch (carenum)
            {
                case carenum.aodi:
                    runable = new Aodi();
                    break;
                case carenum.baoma:
                    runable = new BaoMa();
                    break;
                case carenum.benchi:
                    runable = new Benchi();
                    break;
                default:
                    break;
            }
            runable.GuaDang();
            runable.Run();

        }
        public enum carenum
        {
            aodi, baoma, benchi
        }

    }
}
