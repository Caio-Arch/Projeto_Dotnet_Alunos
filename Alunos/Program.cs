using System;

namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
           Alunos[] alunos = new Alunos[5];
           var indiceAluno = 0;
           string Opcaousuario = Opcoes();
           while(Opcaousuario.ToUpper() != "X")
           {
               switch (Opcaousuario)
               {
                     case "1":
                     Console.WriteLine("Informe o nome do aluno:");
                     var aluno = new Alunos();
                     aluno.Nome = Console.ReadLine();

                     Console.WriteLine("Informe a Nota do aluno:");

                     if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                     {
                        aluno.Notas = nota;
                     }
                     else
                     {
                        throw new ArgumentOutOfRangeException("O Valor da nota deve ser Decimal");
                     }

                     alunos[indiceAluno] = aluno;
                     indiceAluno++;
                     
                      break;

                     case "2":
                     foreach (var a in alunos)
                     {
                        if(!string.IsNullOrEmpty(a.Nome))
                        {
                            Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Notas}");
                        }
                         
                     }
                       break;

                     case "3":
                     decimal notaTotal = 0;
                     var nrAlunos = 0;

                     for(int i=0; i < alunos.Length; i++)
                         {
                             if(!string.IsNullOrEmpty(alunos[i].Nome))
                             {
                               notaTotal = notaTotal + alunos[i].Notas;
                               nrAlunos++;
                             }
                         }

                        var mediaGeral = notaTotal / nrAlunos;
                        Console.WriteLine($"Média Geral: {mediaGeral}");

                       break;

                     default:
                        throw new ArgumentOutOfRangeException();
               }

               Opcaousuario = Opcoes();
           }
        }
        private static string Opcoes()
        {
           Console.WriteLine();
           Console.WriteLine("Informe a opção desejada:");
           Console.WriteLine();
           Console.WriteLine("1- Inserir Novo Aluno");
           Console.WriteLine("2- Listar Alunos");
           Console.WriteLine("3- Calcular Média Geral");
           Console.WriteLine("X - Sair");
           Console.WriteLine();

           string Opcaousuario = Console.ReadLine();
           Console.WriteLine();
           return Opcaousuario;
        }
        
         
    }

}