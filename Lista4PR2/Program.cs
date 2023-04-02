using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exerc1
            //"sim é verdadeira. Pois o proprio programa realiza a conversão das variáveis. por exemplo:" +
            //   "a = 10
            //   "b = float(a)"
            //   "print(b)  # saída: 10.0
            //   "# atribuindo um valor do tipo float para uma variável do tipo int
            //   "c = 5.6
            //   "d = int(c)
            //   "print(d)  # saída: 5"

            //exerc2
            //o console readline le a linha inteira, e o console.read le o caracter, o read line responde em strig e o console.read em int, (inteiro)

            //exerc3
            // se o valor digitado pelo usuário é condizente ao tipo de variavel, caso contrario o codigo falhará.

            //exerc 4
            //int num, num2, num3;
            //Console.WriteLine("Entre com um número: ");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;
            //num3 = num % 2;
            //if (num3 == 0 && num2 * 2 > 10)
            //    Console.WriteLine("Mensagem 1");
            //else
            //    Console.WriteLine("Mensagem 2");
            //o proposito do programa é saber se o resto do numero por 2 é 0, se for aparecerá mensagem 1, caso contrario aparecerá mensagem 2


            //exerc 5
            //double s, v, t, sf;
            //Console.WriteLine("digite o valor da posicao inicial: ");
            //s = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite o valor da velocidade: ");
            //v = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite o deslocamento: ");
            //t = double.Parse(Console.ReadLine());
            //sf = s + (v * t);
            //Console.WriteLine("o local é : " + sf);

            //exerc6 
            Random rnd = new Random();
            int numero = rnd.Next(1, 100);
            switch (numero)
            {
                case 1:
                    %3 = 0;
                    break;
                case 2:
                     % 5 = 0;
                    break;
                case 3:
                    %10 = 0;
                    break;





            }

            //exerc7

            //exerc 8





        }
    }
}