using System;
using System.Text.Json;
using Student;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace _1_Карточка_студента_R
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Начало Main");
             await StudentAsync.ReadWriteAsync();
            Console.WriteLine("Конец Main");
        }       
        
    }
}
