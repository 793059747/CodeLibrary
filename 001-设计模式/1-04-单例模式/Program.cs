using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_04_单例模式
{
    /// <summary>
    /// 1 单例模式(单线程和多线程)
    /// 2 单例模式的三种写法
    /// 3 单例模式的优缺点
    /// 4 深度探讨单例模式应用场景      
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region 单线程调用
                //for (int i = 0; i < 5; i++)
                //{
                //    Singleton singleton = Singleton.CreateInstance();
                //    singleton.Show();
                //}
                #endregion

                #region 多线程调用：懒汉式
                //for (int i = 0; i < 5; i++)
                //{
                //    Task.Run(() =>//启动一个线程执行这些动作；可以认为5个同时执行
                //    {
                //        Singleton singleton = Singleton.CreateInstance();
                //        singleton.Show();
                //    });
                //}
                #endregion            

                #region 多线程调用：饿汉式（静态构造函数）
                for (int i = 0; i < 5; i++)
                {
                    SingletonSecond singletonSecond = SingletonSecond.CreateInstance();
                    singletonSecond.Show();
                }
                #endregion

                #region 多线程调用：饿汉式（静态字段）  
                //for (int i = 0; i < 5; i++)
                //{
                //    Task.Run(() =>
                //    {
                //        SingletonThird singletonThird = SingletonThird.CreateInstance();
                //        singletonThird.Show();
                //    });
                //}
                #endregion  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
