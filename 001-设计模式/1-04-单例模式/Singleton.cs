using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_04_单例模式
{
    /// <summary>
    /// 单例类：一个构造对象很耗时耗资源类型
    /// 
    /// 懒汉式
    /// </summary>
    public sealed class Singleton
    {

        /// <summary>
        /// 构造函数耗时耗资源
        /// </summary>
        private Singleton()
        {
            Console.WriteLine($"{this.GetType().Name}被构造一次");
        }

        private static Singleton _Singleton = null;
        private static readonly object Singleton_Lock = new object();
        public static Singleton CreateInstance()
        {
            #region 单线程调用
            if (_Singleton == null)//这个判断不能去掉，保证只初始化一次
            {
                _Singleton = new Singleton();
            }
            #endregion

            #region 多线程调用
            //if (_Singleton == null)
            //{
            //    lock (Singleton_Lock)//可以保证任意时刻只有一个线程进入，其他线程等待
            //    {
            //        if (_Singleton == null)//这个判断不能去掉，保证只初始化一次
            //        {
            //            _Singleton = new Singleton();
            //        }
            //    }
            //}
            #endregion

            return _Singleton;
        }
        public void Show()
        {
            Console.WriteLine($"这里是{this.GetType().Name}.Show");
        }



    }
}
