using System;
namespace AddElement
{
    class Program{
        static void Main(string[] args)
        {
            
            nhapMang();
        }
    static void nhapMang(){
        Console.WriteLine("Enter number  n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Index of number input");
        int index=Convert.ToInt32(Console.ReadLine());
        if (index<1 || index>=arr.Length){
                Console.WriteLine("Khong thuc hien duoc");}
        else {
            Console.WriteLine("Nhap vao so can chen:");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i=n-1;i>index;i--){
            arr[i]=arr[i-1];//dich chuyen phan tu sang ben trai
            }arr[index]=value;
        }
        for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
    }
    
}}



