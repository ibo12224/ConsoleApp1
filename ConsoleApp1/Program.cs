using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int []charge = new int[5];
            int money;
            money = int.Parse(Console.ReadLine());//입력받은 문자열 int형으로 변환
            int res = 1000 - money;//거슬러 주어야 할 금액
            if (res >= 500)//동전 금액
            {
                charge[0] = money / 500;
                money %= 500;
            }
            if (money >= 100)
            {
                charge[1] = money / 100;
                money %= 100;
            }
            if (money >= 50)
            {
                charge[2]= money / 50;
                money %= 50;
            }
            if (money >= 10)
            {
                charge[3] = money / 10;
                money %= 10;
            }
            if (money >= 5)
            {
                charge[4] = money / 5;
                money %= 5;
            }
            //money변수에 남은 수는 1원 짜리 동전의 개수
            for (int i = 0; i < 5; i++)
                money += charge[i];//동전 들의 합
            Console.WriteLine("동전의 개수:"+money);

        }
    }
}