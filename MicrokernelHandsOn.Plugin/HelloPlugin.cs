using System;
using MicrokernelHandsOn.Contract;

namespace MicrokernelHandsOn.Plugin
{
    public class HelloPlugin : IPlugin  
    {
        public void SaySomething()
        {
            Console.WriteLine("Hello Microkernel");
        }
    }
}
