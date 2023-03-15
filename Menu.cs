using System;
using System.Collections.Generic;


namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue; // Altera a cor de fundo do nosso console (Teminal)
            Console.ForegroundColor = ConsoleColor.Black; // Altera a cor da letra do nosso console (Terminal)            

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen(){
            Console.Write("+");
            for(int i = 0; i<=30; i++)
                Console.Write("-");

            Console.Write("+");            
            Console.Write("\n");            

            for(int lines = 0; lines<=10; lines++){
                Console.Write("|");
                for(int i = 0; i<=30; i++){
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");                 
            }

            Console.Write("+");
            for(int i = 0; i<=30; i++)
                Console.Write("-");
            Console.Write("+");
                       
        }

        public static void WriteOptions(){

            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(1, 3);
            Console.WriteLine("   ========================");
            Console.SetCursorPosition(1, 4);
            Console.WriteLine("  Selecione uma opção abaixo");
            Console.SetCursorPosition(1, 5);
            Console.WriteLine("   ========================");
            Console.SetCursorPosition(1, 7);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(1, 8);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(1, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(1, 10);
            Console.Write("Opção:");

        }

        public static void HandleMenuOption(short option){

            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Select.Show(); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                };
                
                default:Show(); break;
            }
        }
    }
}
