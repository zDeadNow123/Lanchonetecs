using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonetecs {

    internal class Program {


        // Estrutura
        struct Pedido {

            public int idPed;
            public Produto produto;
            public string nomeCli;


            // Construtor
            public Pedido(int idPed, Produto produto, string nomeCli) {

                this.idPed = idPed;
                this.produto = produto;
                this.nomeCli = nomeCli;
            }

            public string writeData() {

                return $"ID: {idPed}, Item: {produto.writeData()}, Cliente: {nomeCli}"; 
            }

        }

        // Estrutura
        struct Produto {

            public int idProd;
            public string nameProd;

            // Construtor
            public Produto(int idProd, string nameProd) {

                this.nameProd = nameProd;
                this.idProd = idProd;

            }

            public string writeData() {
                return this.nameProd;
            }
            
        }

        static void Main(string[] args) {

            Program p = new Program();

            p.Lanchonete();
        }

        public void Lanchonete() {

            List<Produto> Produtos = new List<Produto>();

            Produtos.Add(new Produto(1, "Hamburger"));
            Produtos.Add(new Produto(2, "X-Salada"));
            Produtos.Add(new Produto(3, "X-Tudo"));
            Produtos.Add(new Produto(4, "Coxinha"));
            Produtos.Add(new Produto(5, "Pastel"));

            // Tela Inicial
            Console.WriteLine("Olá, bem vindo a minha humilde lanchonete, você quer 1 lanche? (s/n)");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s") return;

            // Declaração de variáveis
            List<Pedido> Pedidos = new List<Pedido>();
            Queue<string> fila = new Queue<string>();

            while (true) {

                Console.Clear();
                Console.WriteLine("Ok, preciso de mais algumas informações. Nossos produtos são esses:\n");
                Console.WriteLine("1. Hamburger - R$ 15,00");
                Console.WriteLine("2. X-Salada - R$ 25,00");
                Console.WriteLine("3. X-Tudo - R$ 25,00");
                Console.WriteLine("4. Coxinha - R$ 5,00");
                Console.WriteLine("5. Pastel - R$ 25,00");

                Console.WriteLine("\nQual o seu nome?");
                string nomedoCliente = Console.ReadLine();

                Console.WriteLine("\nQual o Produto?");
                int pedidodoCliente = int.Parse(Console.ReadLine());

                Pedidos.Add(new Pedido(JRandom.Range(1, 9000), Produtos[pedidodoCliente - 1], nomedoCliente));

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
