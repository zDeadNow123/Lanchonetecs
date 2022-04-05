using System;
using System.IO;
namespace asdasd {
    internal class Writer {
        public static void write(string file, string content, bool hasNext) {

            try {

                StreamWriter sw = File.AppendText("C:\\Users\\Julio\\Desktop\\arara.json");

                sw.WriteLine(content);
                sw.Close();
            }
            catch (FileNotFoundException) {

                Console.WriteLine("PERAAAAAAAAAAAAAAAAAAAAAAAAAAAI AMIGO, O ARQUIVO QUE VOCE DEFINIU LA NO CODIGO NAO EXISTE!");
            }

        }
    }
}
