using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_04_单例模式
{
    /// <summary>
    /// 饿汉式
    /// </summary>
    public sealed class SingletonSecond
    {

        /// <summary>
        /// 构造函数
        /// </summary>
        private SingletonSecond()
        {
            Console.WriteLine($"{this.GetType().Name}被构造一次");
        }

        private static SingletonSecond _SingletonSecond = null;
        /// <summary>
        /// 静态构造函数：由CLR保证，在第一次使用到这个类型之前，自动被调用且只调用一次
        /// 很多初始化都可以写在这里
        /// </summary>
        static SingletonSecond()
        {
            _SingletonSecond = new SingletonSecond();
        }
        public static SingletonSecond CreateInstance()
        {
            return _SingletonSecond;
        }

        public void Show()
        {
            Console.WriteLine($"这里是{this.GetType().Name}.Show");
        }



    }
}
