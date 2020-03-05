using ConsoleApp1.Classes;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IHMBanque banque = new IHMBanque();
            banque.start();
        }
    }
}
