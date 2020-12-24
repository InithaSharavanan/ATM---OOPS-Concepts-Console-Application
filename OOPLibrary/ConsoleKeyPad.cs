using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLibrary
{
    public class ConsoleKeyPad : IKeyPad
    {
        public int ReadLine()
        {
            string line = Console.ReadLine();
            return int.Parse(line);
        }
        public int Read(int noOfDigits)
        {
            int num = 0;
            int digits = 1;
            if (noOfDigits > 10) noOfDigits = 10;
            for(int i = 0; i < noOfDigits - 1; i++)
            {
                digits *= 10;
            }
            while (digits > 0)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.KeyChar>='0' && key.KeyChar <= '9')
                {
                    num = num + digits * (key.KeyChar - '0');
                    digits = digits / 10;
                }
            }
            Console.WriteLine();
            return num;
        }
    }

}
