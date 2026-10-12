using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace EstudoEmCSharp
{
    internal class DataInput
    {
        public DataInput()
        {
            string name;
            string partnerData;

            int age;
            int roomNumber;
            double salary;

            Console.WriteLine("Digite seu nome: ");
            name = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de quartos: ");
            roomNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu salário: ");
            salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados do seu/sua parceiro(a) (Nome, idade, sexo e profissão) sem virgulas: ");
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine($"Nome: {name}, Idade: {age}, Quarto: {roomNumber}, Salário: {salary}");
            Console.WriteLine($"Dados do(a) parceiro(a) nome: {vet[0]}, idade: {vet[1]}, sexo: {vet[2]}, profissão: {vet[3]}");

        }

    }
}
