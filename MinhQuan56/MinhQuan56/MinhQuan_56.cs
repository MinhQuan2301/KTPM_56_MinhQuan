using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhQuan56
{
    public class MinhQuan_56
    {
        private int a, b;
        public MinhQuan_56(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Execute(string CalSymbol)
        {
            int result = 0;
            switch(CalSymbol)
            {
                case "+":
                    result = this.a + this.b;
                    break;
                case "-":
                    result = this.a - this.b;
                    break;
                case "x":
                    result = this.a * this.b;
                    break;
                case "/":
                    result = this.a / this.b;
                    break;
            }
            return result;

        }
    }
 }

