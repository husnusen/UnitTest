using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
   public  interface IDecorator
    {
        string Decorate(string text, string subText);
    }
}
