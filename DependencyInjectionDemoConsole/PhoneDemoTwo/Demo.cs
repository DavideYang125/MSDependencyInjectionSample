using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemoConsole.PhoneDemoTwo
{
    public interface IPhone
    {
        string PlayGame(string name);
    }

    public class HuaWeiPhone : IPhone
    {
        public string PlayGame(string name)
        {
            return $"{name} 用华为手机玩游戏";
        }
    }

    public class XiaomiPhone : IPhone
    {
        public string PlayGame(string name)
        {
            return $"{name} 用小米手机玩游戏";
        }
    }

    public interface IPerson
    {
        void Play();
    }

    public class XiaoMing : IPerson
    {
        private IPhone iPhone;

        public XiaoMing(IPhone phone)
        {
            iPhone = phone;
        }

        public void Play()
        {
            var info = iPhone.PlayGame("小明");
            Console.WriteLine(info);
        }
    }
}
