using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonetecs {

    internal class Program {
        static void Main(string[] args) {

            Program program = new Program();

            Console.WriteLine("Olá, bem vindo a minha humilde lanchonete, você quer 1 lanche?");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s") return;

            Console.WriteLine("Ok, preciso de mais algumas informações. Nossos produtos são esses:\n");
            Console.WriteLine("1. Hamburger - R$ 15,00");
            Console.WriteLine("2. X-Salada - R$ 25,00");
            Console.WriteLine("3. X-Tudo - R$ 25,00");
            Console.WriteLine("4. Coxinha - R$ 5,00");
            Console.WriteLine("5. Hamburger - R$ 25,00");

            Console.WriteLine("Qual o seu nome?");
            Console.WriteLine("Qual o Pedido?");

            int InputProd = int.Parse(Console.ReadLine());

            //Queue<>

            Console.ReadKey();
        }

    }
}
