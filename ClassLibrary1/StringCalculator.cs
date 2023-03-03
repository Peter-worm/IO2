using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StringCalculator
    {
        public int Add(string number)
        {
            if (number.Length == 0) return 0;
            if(!number.Contains(',')&&!number.Contains('\n')) return int.Parse(number);

            if (number.Contains(',')){
                var numbers = number.Split(',');
                if (numbers.Length==2)
                    return int.Parse(numbers[0]) + int.Parse(numbers[1]);
            }

            if (number.Contains('\n'))
            {
                var numbers = number.Split('\n');
                if (numbers.Length == 2)
                    return int.Parse(numbers[0]) + int.Parse(numbers[1]);
            }


            throw new ArgumentException();
        }
    }
}
