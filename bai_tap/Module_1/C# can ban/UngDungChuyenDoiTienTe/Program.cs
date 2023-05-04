using System;
namespace UngDungChuyenDoiTienTe{
    class Program{
        static void Main(string [] args){
            const float rate =23000;
            Console.WriteLine("Enter number of Usd: ");
            float Usd = float.Parse(Console.ReadLine());
            float Vnd = rate*Usd;
            Console.WriteLine(Usd +" Usd = " + Vnd +"Vnd " );
        }
    }
}