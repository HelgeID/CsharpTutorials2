//класи, події (приклад)
using System;

namespace ConsoleApplication
{
    public delegate void PressKeyEventHandler();

    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyR = null;
        public event PressKeyEventHandler PressKeyG = null;
        public event PressKeyEventHandler PressKeyB = null;

        public void PressKeyREvent()
        {
            if (PressKeyR != null)
                PressKeyR.Invoke();
        }

        public void PressKeyGEvent()
        {
            if (PressKeyG != null)
                PressKeyG.Invoke();
        }

        public void PressKeyBEvent()
        {
            if (PressKeyB != null)
                PressKeyB.Invoke();
        }

        public void Start()
        {
            while(true)
            {
                string key = Console.ReadLine();

                switch (key)
                {
                    case "r":
                    case "R":
                        PressKeyREvent(); break;
                    case "g":
                    case "G":
                        PressKeyGEvent(); break;
                    case "b":
                    case "B":
                        PressKeyBEvent(); break;

                    case "exit":
                        goto Exit;

                    default:
                        Console.WriteLine("You pressed key: {0} Press key R, G, B or exit", key.ToLower());
                        break;
                }
            }
        Exit:
            Console.WriteLine("Exit");
        }
    }

    class Program
    {
        static private void PressKeyR_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("R");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static private void PressKeyG_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("G");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static private void PressKeyB_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("B");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Press key R, G, B or exit");

            Keyboard keyboard = new Keyboard();
            keyboard.PressKeyR += new PressKeyEventHandler(PressKeyR_Handler); //keyboard.PressKeyR += PressKeyR_Handler;
            keyboard.PressKeyG += new PressKeyEventHandler(PressKeyG_Handler); //keyboard.PressKeyG += PressKeyG_Handler;
            keyboard.PressKeyB += new PressKeyEventHandler(PressKeyB_Handler); //keyboard.PressKeyB += PressKeyB_Handler;

            keyboard.Start();

            Console.ReadKey();
        }
    }
}
