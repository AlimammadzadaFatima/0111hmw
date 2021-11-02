using System;

namespace _0111hmw
{
    class Program
    {
        static void Main(string[] args)
        { //task1
            Console.WriteLine("Cumle daxil edin");
           string sozler = Console.ReadLine();
            Soz(sozler);
            ///2
            Console.WriteLine("Cumle daxil edin");
            string sozler1 = Console.ReadLine();
            Console.WriteLine(MetodSert(sozler1)); 
            ///3
            int[] intarray = {0,1,2,3,4};
            Console.WriteLine("Reqem daxil edin");
            int i = Convert.ToInt32(Console.ReadLine());
            Sozler(intarray, i);
            //4
            Console.WriteLine("cumle daxil edin");
            string sozler2 = Console.ReadLine();
            Soztap(sozler2);
          
        }
        static void Soz(string sozler)
        {   
           
              var text = sozler.Trim().Split(' ');
            foreach (var item in text)
            {
                if (item == "")
                    continue;
                 Console.WriteLine($"{item}");
            }
        }
        
        static bool MetodSert(string sozler1)
        {   bool sert = false;
            bool sert1 = false;
            bool sert2 = false;
            bool sert3 = false;
            foreach (var item in sozler1)
            {
                if (char.IsLetter(item))
                   sert1 = true;
                if (char.IsUpper(item))
                    sert2 = true;
                if (char.IsDigit(item))
                    sert3 = true;
                if(sert1==true&&sert2==true&&sert3==true)
                    sert = true;
                
            }
            return sert;
        }
        static void Sozler (int [] array, int i)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = i;
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        static string [] Soztap (string sozler)
        {
            string[] words = sozler.Trim().Split(' ');
            foreach (var item in words)
            { 
                Console.WriteLine(item);
            }
            return words;
        }
        
    }
}
