using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

                    Console.WriteLine("몇개중 몇개를 뽑을 예정인가요오?");

                    int all, select;
                    all = int.Parse(Console.ReadLine());
                    select = int.Parse(Console.ReadLine());

                    for (int i = 0; i < select; i++)
                    {
                        Console.WriteLine("선택된 번호는 {0} 입니다아.", r.Next(1, all + 1));
                    }

                    Console.WriteLine("계속하려면 아무 키나 눌러주세요오");
                    Console.ReadLine();
           
        }
    }
}
