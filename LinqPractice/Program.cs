using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linq를 사용하지 않은 세련되지 않은 정렬 방법
            List<int> input=new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            List<int> output = new List<int>();

            foreach (var item in input)
            {
                if (item % 2 == 0) output.Add(item);

            }
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            var output2=from item in input
                        where item % 2 == 0
                        orderby item descending
                        select item;
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            int[] output3=output2.ToArray();
            List<int> output4 = output2.ToList();

            //익명객체 실습

            var output5=from item in input
                where item %2==0
                select new
                {
                    A = item * 2,
                    B = item * item,
                    C = 100
                };
            foreach (var item in output5)
            {
                Console.WriteLine(item.A);
                Console.WriteLine(item.B);
                Console.WriteLine(item.C);
                Console.WriteLine();

            }
            List<product> foods = new List<product>()
            {
                new product() { Name="군고구마", Price=1000},
                new product() { Name="사과", Price=2000},
                new product() { Name="바나나", Price=3000},
                new product() { Name="배", Price=1500},
                new product() { Name="감자", Price=500},
                new product() { Name="토마토", Price=500},
                new product() { Name="옥수수", Price=1000},
                new product() { Name="자두", Price=2000}
            };

            var output6 = from food in foods
                          where food.Price > 1500
                          orderby food.Price ascending
                          select food;
            foreach (var item in output6)
            {
                Console.WriteLine(item);
            }
        }
    }
}
