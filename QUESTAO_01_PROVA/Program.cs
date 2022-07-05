using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_01_PROVA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nome:julio Duarte Batista RA:6322046 

            /*1 - Faça um programa que receba o nome do aluno, nota de trabalho, nota da prova 1 e nota da prova 2.
              Calcule a média  final (média simples) e apresente o conceito obtido seguindo a seguinte formula:

              O conceito da será calculado da seguinte forma:

              Se a nota final for maior ou igual a 8.5, então o conceito é A.
              Se a nota final estiver entre 7.0 e 8.4, então o conceito é B.
              Se a nota final estiver entre 6.0 e 6.9, então o conceito é C.
              Se a nota final estiver entre 0.1 e 5.9, então o conceito é D.
              Se a nota final for igual a 0.0, então o conceito é E.*/

            string aluno;
            double trabalho,prova1, prova2, media;

            Console.WriteLine("Digite o nome do aluno(a): ");
            aluno = Console.ReadLine();

            Console.WriteLine("Digite a nota do trabalho: ");
            trabalho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota da prova 1: ");
            prova1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota da prova 2: ");
            prova2 = Convert.ToDouble(Console.ReadLine());

            media = (prova1 + prova2 + trabalho) / 3;

            if (media >= 8.5 && media == 10)
            {
                Console.WriteLine("O aluno(a) " + aluno + " obteve a nota final " + media + " e seu conceito é: A.");
            }
            else if (media >= 7.0 && media <= 8.4)
            {
                Console.WriteLine("O aluno(a) " + aluno + " obteve a nota final " + media + " e seu conceito é: B.");
            }
            else if (media >= 6.0 && media <= 6.9)
            {
                Console.WriteLine("O aluno(a) " + aluno + " obteve a nota final " + media + " e seu conceito é: C.");
            }
            else if (media >= 0.1 && media <= 5.9)
            {
                Console.WriteLine("O aluno(a) " + aluno + " obteve a nota final " + media + " e seu conceito é: D.");
            }
            else if (media == 0.0)
            {
                Console.WriteLine("O aluno(a) " + aluno + " obteve a nota final " + media + " e seu conceito é: E.");
            }
            else
            {
                Console.WriteLine("Nota final invalida, tente novamente!.");
            }

            Console.ReadLine();
        }
    }
}
