using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 使用Boss类，简单工厂基础实现
            //Boss boss = new Boss();
            //boss.UseCar(Boss.carenum.aodi);
            #endregion

            #region 使用Boss B,简单工厂配置文件实现

            //BossB bossB = new BossB();
            //bossB.UseCar();
            #endregion

            #region 配置文件+反射实现
            BossC bossC = new BossC();
            bossC.UseCarflaction().Run();
            #endregion


        }
    }
}
