using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLibrary
{
    public interface IKeyPad
    {
       int ReadLine();
       int Read(int noOfDigits);
    }
}
