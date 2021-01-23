using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(10, "Samet");
            myDictionary.Add(9, "Murat");
            myDictionary.Add(8, "Gökhan");
            myDictionary.Add(7, "Çağrı");

            foreach (var names in myDictionary.Keys)
            {
                Console.WriteLine(names);
                
            }   

            foreach (var numbers in myDictionary.Values)
            {
                Console.WriteLine(numbers);
            }
            
           
        }
    }
}
