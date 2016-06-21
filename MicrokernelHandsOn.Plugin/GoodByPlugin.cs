using System;
using MicrokernelHandsOn.Contract;

namespace MicrokernelHandsOn.Plugin
{
    public class GoodByPlugin : IPlugin
    {
        public void SaySomething()
        {
            Console.WriteLine("Goodbye Microkernel");
        }
    }
}