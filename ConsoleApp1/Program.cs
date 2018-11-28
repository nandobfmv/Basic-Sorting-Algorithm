using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //-------------------------------------------------------<Globals>---------------------------------------------------------//
        public static int[] Numbers { get; set; }
        public static int ArrSize;
        //-------------------------------------------------------</Globals>--------------------------------------------------------//
        //
        //-------------------------------------------------------<Classes>---------------------------------------------------------//
        public static Random randomizer = new Random();
        //-------------------------------------------------------</Classes>--------------------------------------------------------//
        //
        //-------------------------------------------------------<Main Code>-------------------------------------------------------//

        static void Main(string[] args)
        {
            //-----<Definir do tamanho do Array>------//
            Console.Write("Selecione o tamanho do Array: ");
            string SNumber = Console.ReadLine();
            while (!int.TryParse(SNumber, out ArrSize))
            {
                Console.WriteLine("Número não reconhecido");
                Console.Write("Selecione o Tamanho do Array: ");
                SNumber = Console.ReadLine();
            }
            Console.WriteLine("Tamanho do Array definido: " + ArrSize);
            Console.ReadKey();
            Console.Clear();
            Numbers = new int[ArrSize];
            //-----</Definir do tamanho do Array>-----//
            //
            //-----<Preencher Array aleatoriamente>------//
            for (int i = 0; i < ArrSize; i++)
            {
                Numbers[i] = randomizer.Next(100);
            }
            Console.Clear();
            Console.WriteLine("O seguinte Array foi gerado:");
            for (int i = 0; i < ArrSize; i++)
            {
                Console.Write("{0} ", Numbers[i]);
            }
            Console.WriteLine("", "Pressione qualquer tecla para Organizar o Array:");
            Console.ReadKey();
            //-----</Preencher Array aleatoriamente>-----//
            //
            //-----<Ordena Array>-----//
            SortArray(ArrSize);
            //-----</Ordena Array>----//
            Console.WriteLine("Lista Após ordenação: ");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + " ");
            }
            Console.WriteLine("Pressione Enter para Sair: ");
            Console.ReadKey();
        }
        //-------------------------------------------------------</Main Code>------------------------------------------------------//
        //
        //-------------------------------------------------------<Methods>---------------------------------------------------------//
        public static void SortArray(int size)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Numbers[j] > Numbers[i])
                    {
                        int Holder = Numbers[i];
                        Numbers[i] = Numbers[j];
                        Numbers[j] = Holder;
                    }
                }
            }
        }
        //-------------------------------------------------------</Methods>--------------------------------------------------------//
    }
}
