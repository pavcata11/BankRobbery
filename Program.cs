using System;
using System.Collections.Generic;

namespace BankRbbery
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of suspects: ");
            int count = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            List<string> indications = new List<string>();
            Dictionary<string, string> dic = new Dictionary<string, string>(); 
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i+1}. Name: ");
                names.Add(Console.ReadLine());
            }
            // t -> невиинен - 1
            // {име} - t  -> човека с това име е виновен
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(names[i] + " said: ");
                indications.Add(Console.ReadLine());
                if (indications[i] == "t")
                {
                    dic.Add(names[i], "0");
                }
                else if (indications[i].Split(" - ")[1] == "t")
                {
                    dic.Add(names[i], indications[i].Split(" - ")[0]+ " Contrast "+ names[i]);
                    dic[indications[i].Split(" - ")[0]] = names[i] + " Contrast "+ indications[i].Split(" - ")[0];
                }


            }
            
            foreach (var item in dic)
            {
                if(item.Value == "0")
                {
                    Console.WriteLine(item.Key + " " + "is guilty"); 
                }
            }
            //Примерен вход
            /*  3
              Ivan
              Dragan
              Petkan
              t
              t
              Dragan - t*/
            // Output must be - Ivan is quilty
            // Идеята ми е: Второто и третотото твърдения са противоположни. Според условието на задачата има само едно
            // верно твърдение, сл.първото твърдение също е "лъжа", т.е. "Иван е виновен".
        }
    }
}
