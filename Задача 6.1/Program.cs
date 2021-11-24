using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
			string text = Console.ReadLine();
			string[] str = text.Split(' ');
			int index = 0; int maxlen = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i].Length > maxlen)
				{
					maxlen = str[i].Length;
					index = i;
				}
			}
			Console.Write("Самое длинное слово: {0}", str[index]);
			Console.ReadKey();

		}
    }
}
