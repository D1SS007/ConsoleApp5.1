using System;
using System.Collections.Generic;

namespace ConsoleApp5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;

            Dictionary<string,string> fruits = new Dictionary<string, string>();

            fruits.Add("Ананас", "Ананас хохлатый — многолетнее травянистое растение, вид рода Ананас семейства Бромелиевые.");            
            fruits.Add("Груша", "Груша — род плодовых и декоративных деревьев и кустарников семейства Розовые.");            
            fruits.Add("Киви", "Киви — название плодов культурных сортов растений рода Актинидия, принадлежащих к видам Актинидия китайская или Актинидия деликатесная.");
            fruits.Add("Мандарин", "Мандарин — небольшое вечнозелёное дерево, вид рода Цитрус семейства Рутовые.");
            fruits.Add("Яблоко", "Яблоко — сочный плод яблони, который употребляется в пищу в свежем и запеченном виде, служит сырьём в кулинарии и для приготовления напитков.");

            while (isWorking)
            {
                Console.WriteLine("СЛОВАРЬ ФРУКТОВ.\nВведите название фрукта");

                string userInput = Console.ReadLine();

                if (fruits.ContainsKey(userInput))
                {
                    Console.WriteLine(fruits[userInput] + "\n");
                }
                else if (userInput == "exit")
                {
                    isWorking = false;
                }
                else
                {
                    Console.WriteLine("Такого фрукта в словаре нет\n");
                }
            }  
        }
    }
}
