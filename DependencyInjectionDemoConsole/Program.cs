
using DependencyInjectionDemoConsole.PhoneDemoTwo;
using System;

namespace DependencyInjectionDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HuaWeiPhone huaweiPhone = new HuaWeiPhone();
            PhoneDemoTwo.XiaoMing xiaoming = new PhoneDemoTwo.XiaoMing(huaweiPhone);

            xiaoming.Play();

            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
