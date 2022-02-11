using System;
 namespace fibonacci 
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            List<int> fibonacci = new List<int>{0,1};
            int n =0;
            float fiboTotal = 0;
            float fiboAverage = 0;
            try{
                Console.WriteLine("lütfen Fibonacci serisinin derinliğini giriniz");
                n = Convert.ToInt32(Console.ReadLine());
                }
            catch(Exception e){
                Console.WriteLine(e.Message);
                }
            while (n > fibonacci.Count)
            {
                fibonacci.Add(fibonacci[fibonacci.Count-1]+ fibonacci[fibonacci.Count-2]);
            }
            foreach (var item in fibonacci)
            {
                fiboTotal += item;    
            }
            fiboAverage = fiboTotal/fibonacci.Count;
            Console.WriteLine("_______________ortalama____________________");
            Console.WriteLine(fiboAverage);
            
        }
     }
 }