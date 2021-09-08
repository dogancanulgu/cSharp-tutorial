using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time >= 6 && time < 11)
                System.Console.WriteLine("Günaydın");
            if(time <= 10) 
                System.Console.WriteLine("iyi günler");
            else 
                System.Console.WriteLine("iyi geceler");
            
            string sonuc = time <= 18 ? "iyi günler" : "iyi geceler";
            sonuc = time >= 6 && time < 11 ? "günaydın" : time <= 18 ? "iyi günler" : "iyi geceler";
            System.Console.WriteLine(sonuc);
        }
    }
}
