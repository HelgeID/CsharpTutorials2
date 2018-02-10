﻿//класи, потоки (завершення вторинного потока)
using System;
using System.Threading;

namespace ConsoleApplication
{
    class Program
    {
        static void WriteSecond()
        {
            while (true) {
                Console.WriteLine(new string(' ', 15) + "Secondary");
                Thread.Sleep(500);
            }
        }
        
        static void Main(string[] args)
        {
            //робота вторинного потока
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();

            //робота первинного потока
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Primary");
                Thread.Sleep(500);
            }
            thread.IsBackground = true;//завершуємо вторинний потік
        }
    }
}
