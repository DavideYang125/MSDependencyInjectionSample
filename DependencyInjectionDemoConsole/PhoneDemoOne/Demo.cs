using System;

namespace DependencyInjectionDemoConsole.PhoneDemoOne
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
        public void Play()
        {
            var phone = new HuaWeiPhone();
            var info = phone.PlayGame("小明");
            Console.WriteLine(info);
        }
    }
}
