﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IOrder> OrderList = new List<IOrder>();
            for (int i = 0; i < 50_000; i++)
            {
                OrderList.Add(Order.Factory.CreateWithRandomData());
            }

            foreach(var item in OrderList.TakeLast(5))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(OrderList.First());
            Console.WriteLine(OrderList.Last());
        }
    }
}
//Exercises:
//1. Skriv ut antal ordrar, värdet av alla ordrar, de 5 största ordrarna, antal ordrar < 1000kr, summan av frakt för alla ordrar < 1000kr
//2. Skriv ut en lista på alla länder som det kommit ordrar från. Varje land ska skrivas ut bara en gång
//3. Skriv ut antal ordrar där leverans skett mer an 15 dagar efter orderdatum
//4. Antalet ordrar och värdet av alla ordrar i Finland
//5. Utmaning: Använd GroupBy för att lista land, antalet ordrar och värdet av ordrarna per land
//6. Utmaning: Använd GroupBy för att lista de 5 största ordrarna per land
//7. Utmaning: Använd Average för att räkna ut medel leveranstiden för alla ordrar
