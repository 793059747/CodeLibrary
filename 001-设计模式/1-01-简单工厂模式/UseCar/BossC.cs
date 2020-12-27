using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ICar;

namespace UseCar
{
    /// <summary>
    /// 简单工厂通过反射，实现控制可扩展.
    /// </summary>
    public class BossC
    {

        public IRunable UseCarflaction()
        {
            string cartype = System.Configuration.ConfigurationManager.AppSettings["UseCarflaction"];
            Assembly assembly = Assembly.Load(cartype.Split(',')[1]);
            Type type = assembly.GetType(cartype.Split(',')[0]);
            return (IRunable)Activator.CreateInstance(type);

        }


    }
}
