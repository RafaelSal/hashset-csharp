using System;
using System.Collections.Generic;

namespace hashset
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializa conjunto hashset do curso A
            HashSet<int> CursoA = new HashSet<int>();

            //Entrada de dados para grupo CursoA
            Console.Write("O curso A possui quantos alunos? ");
            int nCursoA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            //Loop para adicionar N estudantes no conjunto CursoA
            for (int i = 0; i < nCursoA; i++)
            {
                int a = int.Parse(Console.ReadLine());
                CursoA.Add(a);
            }


            //Inicializa conjunto hashset do curso B
            HashSet<int> CursoB = new HashSet<int>();

            //Entrada de dados para grupo CursoB
            Console.Write("O curso B possui quantos alunos? ");
            int nCursoB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            //Loop para adicionar N estudantes no conjunto CursoB
            for (int i = 0; i < nCursoB; i++)
            {
                int b = int.Parse(Console.ReadLine());
                CursoB.Add(b);
            }

            //Inicializa conjunto hashset do curso C
            HashSet<int> CursoC = new HashSet<int>();

            //Entrada de dados para grupo C
            Console.Write("O curso C possui quantos alunos? ");
            int nCursoC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            //Loop para adicionar N estudantes no conjunto CursoC
            for (int i = 0; i < nCursoC; i++)
            {
                int c = int.Parse(Console.ReadLine());
                CursoC.Add(c);
            }


            //Iniciliza novo grupo para para receber união dos grupos 
            HashSet<int> Novo = new HashSet<int>();
            //Gera intersecção dos grupos e mostra na tela
            Novo.UnionWith(CursoA);
            Novo.UnionWith(CursoB);
            Novo.UnionWith(CursoC);

            Console.Write("Total de alunos: " + Novo.Count);
            Console.WriteLine();
        }
    }
}
