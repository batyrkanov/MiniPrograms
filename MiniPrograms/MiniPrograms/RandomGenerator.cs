using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPrograms
{
    class RandomGenerator
    {
        private int count = 0;
        Random rnd = new Random();
        private int n;

        public int Increment()//метод инкремент
        {
            return count++;
        }

        public int Dicrement()//метод дикремент
        {
            return count--;
        }

        public int Reset()//очистить
        {
            return count = 0;
        }

        public int Generator(string a, string b) //метод генератора рандомных чисел
        {
            n = rnd.Next(Convert.ToInt32(a), Convert.ToInt32(b));
            return n;
        }

    }
}
