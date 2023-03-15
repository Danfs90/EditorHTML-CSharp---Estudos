using System;
using System.Diagnostics;
using System.IO;

namespace EditorHTML
{

    public static class Select
    {

        public static void Show()
        {

            Console.Clear();
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Olá, selecione algum dos arquivos ja salvos!");

            string folderPath = @"C:\Users\Logs\";

            string[] files = Directory.GetFiles(folderPath);
            
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{i+1}: {Path.GetFileName(files[i])}");
            }

            int selectedIndex = int.Parse(Console.ReadLine()) - 1;

            if (selectedIndex >= 0 && selectedIndex < files.Length)
            {
                string selectedFile = files[selectedIndex];

                string content = File.ReadAllText(selectedFile);

                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }            

            Console.ReadKey();
            WriteOptions();
            var option = short.Parse(Console.ReadLine());
            HandleSeleOption(option);            
        }

      public static void WriteOptions(){

            Console.WriteLine("========================");
            Console.WriteLine("Selecione uma opção abaixo");
            Console.WriteLine("========================");
            Console.WriteLine("1 - Selecionar outro arquivo");
            Console.WriteLine("2 - Retornar ao Menu");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção:");

        }        
        public static void HandleSeleOption(short option){

            switch (option)
            {
                case 1: Show(); break;
                case 2: Menu.Show(); break;
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