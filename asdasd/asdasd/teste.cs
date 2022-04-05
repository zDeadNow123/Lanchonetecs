using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdasd {
    internal class teste {

        public void vejamos() {

            bool arara = true;
            bool arara2 = true;
            bool arara3 = true;

            while (arara) { 
            
                while (arara2) {

                    Console.WriteLine("Digite o nome de usuario");
                    Console.WriteLine("Digite a senha");
                    Console.WriteLine("Deseja voltar ao inicio?");

                    if (Console.ReadLine().ToLower() != "s") arara2 = false;
                }

                while (arara3) {
                    Console.WriteLine("adasdasds");
                    Console.WriteLine("12312312312");
                    Console.WriteLine("Deseja voltar ao inicio?");

                    if (Console.ReadLine().ToLower() != "s") arara3 = false;
                    if (Console.ReadLine().ToLower() != "n") {

                        arara = false;
                        arara3 = false;
                    }

                }
            }


            Console.ReadKey();
        }
    }
}
