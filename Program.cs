using System;

namespace HW2603
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = 700,discount = 0;
            if(num >= 1000){
                discount = num / 100 * 5;
            }
            else if(num >= 500){
                discount = num / 100 * 3;
            }
            Console.WriteLine("You have to pay with discount:"+(num-discount)+"$$$$$$$$$$$$$$$$$$$$$\nAnd please send for KHurshed 10000000000000000$$$$$$$$$$$$ for Macbook Pro 16");  
            int a=0,b=1,c=2,d=3,u=0;
            if(a<b&&b<c&&c<d){
                Console.WriteLine("They are growing up");
            }
            else if(a!=b&&b!=c&&c!=d){
                u = a < b && a < c && a < d ? a : c < b && c < a && c < d ? c : d < a && d < c && d < b ? d : b < a && b < c && b < d ? b : 0;
                Console.WriteLine(u);
            }
            else if(a==b&&b==c&&c==d){
                Console.WriteLine((a*b*c*d));
            }
            int g = 5,h = 6,j = 7,k = 0;
            if(!(g >= b && h >= j)){
                if(h >= g){
                    k = g;
                    g = h;
                    h = k;
                }
                if(j >= g){
                    k = g;
                    g = j;
                    j = k;
                }
                if(j >= h){
                    k = h;
                    h = j;
                    j = k;
                }
            }
            System.Console.WriteLine(g);
            System.Console.WriteLine(h);
            System.Console.WriteLine(j);
            Console.ReadKey(); 
        }
    }
}
