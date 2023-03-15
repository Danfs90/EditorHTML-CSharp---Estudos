using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;
using System.Threading;
using System.ComponentModel;
using System.IO;

namespace EditorHTML
{

    public class Editor
    {
        public static Files files = new Files();
        public static void Show(){

            Console. Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console. Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-------------------------");
            Start();
        }

        public static void Start(){

            var file = new StringBuilder();

            do{
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("========================");
            Console.WriteLine("Selecione uma op��o abaixo");
            Console.WriteLine("========================");
            Console.WriteLine("1 - Salvar o arquivo");
            Console.WriteLine("2 - Visualizar o arquivo");
            Console.WriteLine("3 - Voltar ao Menu");

            var option = Console.ReadLine();
            
            optionsTwo((int.Parse(option), file.ToString()));

        }

        public static void optionsTwo((int, string) tuple)
        {
            switch (tuple)
            {
                case (1, var file): 
                
                Console.WriteLine("Qual o nome do arquivo a ser salvo?");
                string name = Console.ReadLine();
            
                using (StreamWriter sw = new StreamWriter($"C:\\Users\\Logs\\{name}.txt")){
                    sw.Write(file);
                    }; Menu.Show(); break;

                case (2, var file): Viewer.Show(file); break;
                case (3, _): Menu.Show(); break;
            };
        }


    }
}
