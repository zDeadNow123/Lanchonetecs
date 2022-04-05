using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace asdasd {
    internal class Autenticar {

        JsonSerializer serializer = new JsonSerializer();

        List<Funcionario> funcionarios = new List<Funcionario>();

        string path = "C:\\Users\\Julio\\Desktop\\arara.json";

        public void cadastrar() {


            Console.WriteLine("Ola pessoa, voce entrou no sistema. Deseja cadastrar um funcionario? Claro ne");

            Console.WriteLine("Quantos funcionários você deseja cadastrar?");
            int qtdFunc = int.Parse(Console.ReadLine());
            Console.WriteLine();


            for (int i = 0; i < qtdFunc; i++) {
                funcionarios.Add(new Funcionario());

                Console.WriteLine("Digite o ID do Funcionario");
                funcionarios[i].id = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite o Nome do Funcionario");
                funcionarios[i].nome = Console.ReadLine();
                Console.WriteLine();
            }

            string output = JsonConvert.SerializeObject(funcionarios);

            Writer.write("C:\\Users\\Julio\\Desktop\\arara.json", output, true);
        }

        public void verificarCadastro() {

            //Funcionario deserializedProduct = JsonConvert.DeserializeObject<Funcionario>(Reader.read(path));

            Console.WriteLine(path);
            //Console.WriteLine(deserializedProduct);

            Console.ReadKey();
        }

    }
}
