using System;
using OOPLibrary;

namespace OOPProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var screen = new ConsoleScreen();
            var keypad = new ConsoleKeyPad();
            ATM atm = new ATM(screen, keypad);
            atm.Start();
        }
    }
}
