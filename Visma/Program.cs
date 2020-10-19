using System;
using System.Collections.Generic;

namespace Visma
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
       
            Console.WriteLine("Datums: " + document.date());
            Console.WriteLine("Numurs: " + document.number);
            Console.WriteLine("maxSumma: " + document.maxSumm);
            CreateTable createTable = new CreateTable();

            List<List<string>> table = createTable.createTable();
            Console.WriteLine("\nKods     Summa");
            foreach (List<string> rows in table)
            {
                
                foreach (string el in rows)
                {

                    Console.Write(el + "        ");
                }
               
                Console.WriteLine();
            }
            
            Console.WriteLine("\nKopējais dokumenta rindu skaits: " + table.Count);
            Console.WriteLine("Kopējā dokumenta summa: " + createTable.endSum);
            Console.WriteLine("Pēdēja summa: " + createTable.lastSum);
            Console.WriteLine("Pārsniegta dokumenta Maksimālā summa par: " + Math.Abs(document.maxSumm-(createTable.endSum + createTable.lastSum)));
        }
    }
}
