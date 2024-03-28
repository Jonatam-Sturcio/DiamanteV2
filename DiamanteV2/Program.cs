namespace DiamanteV2 {
    internal class Program {
        static void Main(string[] args) {
            /*
             * Quando escrevi isso eu e deus sabíamos como funcionava. 
             * Depois da entrega é só com deus o funcionamento. :)
             */
            Console.Write("Digite uma letra de A - Z: ");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());
            Modelo(letra);
        }
        static void Modelo(char letra) {
            int alvo = letra - 64, aux, aux2 = 1;
            aux = alvo;
            for (int i = 0; i < alvo; i++) {
                Console.Write(new string(' ', aux));
                aux--;
                Console.Write($"{(char)(65 + i)}");
                if (i > 0) {
                    Console.Write(new string(' ', aux2));
                    aux2 += 2;
                    Console.WriteLine($"{(char)(65 + i)}");
                }
                else {
                    Console.WriteLine();
                }
            }
            aux = 2;
            aux2 -= 4;
            for (int i = 1; i < alvo; i++) {
                Console.Write(new string(' ', aux));
                aux++;
                Console.Write($"{(char)((65 + alvo) - (i + 1))}");
                if (i != (alvo - 1)) {
                    Console.Write(new string(' ', aux2));
                    aux2 -= 2;
                    Console.WriteLine($"{(char)((65 + alvo) - (i + 1))}");
                }
                else {
                    Console.WriteLine();
                }
            }
        }
    }
}
