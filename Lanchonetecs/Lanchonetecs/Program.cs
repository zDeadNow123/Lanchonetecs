using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonetecs {

    internal class Program {

        struct Pedido {

            public int idPed;
            public int idProd;
            public string nomeCliente;
            public string[] menu;

            public Pedido(int idPed, int idProd, string nomeCliente) {

                this.idPed = idPed;
                this.idProd = idProd;
                this.nomeCliente = nomeCliente;

                // Menu (Cardapio)
                menu = new string[6];

                menu[1] = "Hamburger";
                menu[2] = "X-Salada";
                menu[3] = "X-Tudo";
                menu[4] = "Coxinha";
                menu[5] = "Pastel";
            }

            public string writeData() {

                return $"ID: {idPed}, Item: {menu[idProd]}, Cliente: {nomeCliente}"; 
            }
        }

        static void Main(string[] args) {

            Program program = new Program();

            Console.WriteLine("Olá, bem vindo a minha humilde lanchonete, você quer 1 lanche? (s/n)");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s") return;

            // Declaração de variáveis
            List<Pedido> Pedidos = new List<Pedido>();
            Queue<string> fila = new Queue<string>();

            string nomedoCliente;

            while (true) {

                Console.Clear();
                Console.WriteLine("Ok, preciso de mais algumas informações. Nossos produtos são esses:\n");
                Console.WriteLine("1. Hamburger - R$ 15,00");
                Console.WriteLine("2. X-Salada - R$ 25,00");
                Console.WriteLine("3. X-Tudo - R$ 25,00");
                Console.WriteLine("4. Coxinha - R$ 5,00");
                Console.WriteLine("5. Pastel - R$ 25,00");

                Console.WriteLine("\nQual o seu nome?");
                nomedoCliente = Console.ReadLine();

                Console.WriteLine("\nQual o Produto?");
                int pedidodoCliente = int.Parse(Console.ReadLine());

                Pedidos.Add(new Pedido(JRandom.Range(1, 3000),pedidodoCliente, nomedoCliente));

                // Adiciona os pedidos a fila
                for (int i = 0; i < Pedidos.ToArray().Length; i++) { 
                
                    fila.Enqueue(Pedidos[i].writeData());
                }

                Console.WriteLine("\nPedidos na fila: ");

                // Lista os pedidos dentro da fila
                foreach (Pedido pedido in Pedidos) {

                    Console.WriteLine(pedido.writeData());
                }

                while (true) { 
                
                    Console.WriteLine("\nPronto, aqui está o seu pedido! Gostaria de pedir mais alguma coisa? (s/n)");
                    string resposta2 = Console.ReadLine().ToLower();

                    if (resposta2 == "s") break;
                    else if (resposta2 == "n") return;
                }

                Console.Clear();
            }

        }

    }
}
