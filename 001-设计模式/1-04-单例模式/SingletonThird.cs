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
    public sealed class SingletonThird
    {
        private SingletonThird()
        {
            Console.WriteLine($"{this.GetType().Name}被构造一次");
        }
        /// <summary>
        /// 静态字段:由CLR保障，在第一次使用这个类型之前，会自动初始化且只初始化一次
        /// </summary>
        private static SingletonThird _SingletonThird = new SingletonThird();
        public static SingletonThird CreateInstance()
        {
            return _SingletonThird;
        }
        public void Show()
        {
            Console.WriteLine($"这里是{this.GetType().Name}.Show");
        }



    }
}
