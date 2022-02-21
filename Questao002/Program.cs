using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Questao002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua senha: ");

            var senha = Console.ReadLine();


            var numero = new Regex(@"[0-9]+");

            var maiusculo = new Regex(@"[A-Z]+");

            var minusculo = new Regex(@"[a-z]+");

            var caracterEspecial = new Regex(@"[!,@,#,$,%,^,&,*,(,),-,+]+");

            var senhaForte = 0;

            if(senha.Length >= 6)

                senhaForte += 1;
                if (numero.IsMatch(senha))
                senhaForte += 1;
                if (maiusculo.IsMatch(senha))
                senhaForte += 1;
                if (minusculo.IsMatch(senha))
                senhaForte += 1;
                if (caracterEspecial.IsMatch(senha))
                senhaForte += 1;


            
                Console.WriteLine("O nivel de força de sua senha é: " + senhaForte.ToString());

            



        }
    }
}
