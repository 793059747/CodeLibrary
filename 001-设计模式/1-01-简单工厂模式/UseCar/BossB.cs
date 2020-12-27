using ClassLibrary;
using ICar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCar
{
    /// <summary>
    /// 简单工厂，配置文件实现版r本，通过修改配置文件，控制程序实现
    /// </summary>
    public class BossB
    {
        string cartype = System.Configuration.ConfigurationManager.AppSettings["Car"];

        public void UseCar()
        {
            carenum carenum = (carenum)(Enum.Parse(typeof(carenum), cartype));

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
            aodi, benchi, baoma
        }
    }
}
