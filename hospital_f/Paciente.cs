using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hospital_f
{
    internal class Paciente
    {
        public string nome;
        public string telefone;
        public string email;
        private string cpf;

        public void cadastrarP()
        {
            Console.WriteLine("INFORMAÇOES PESSOAL");

            Console.WriteLine("Por Favor Digite Seu Nome: ");
            this.nome = Console.ReadLine();

         
            while (true)
            {
                Console.WriteLine("Por Favor Digite CPF: ");
                cpf = Console.ReadLine();

                bool valido = !string.IsNullOrWhiteSpace(cpf) && cpf.All(char.IsDigit) && cpf.Length == 11;

                if (valido) { break; }
                Console.WriteLine("CPF iválido! Deve conter 11 números.");
            }


            Console.WriteLine("INFORMAÇOES PARA CONTATO");

            while (true)
            {
                Console.WriteLine("Por Favor Digite Telefone: ");
                telefone = Console.ReadLine();

                bool valido = !string.IsNullOrWhiteSpace(telefone) && telefone.All(char.IsDigit);

                if (valido) { break; }
                Console.WriteLine("Telefone iválido! Use apenas números.");
            }
            while (true)
            {
                Console.WriteLine("Por Favor Digite Email: ");
                email = Console.ReadLine();

                bool valido = !string.IsNullOrWhiteSpace(email) && email.Contains("@");

                if (valido) { break; }
                Console.WriteLine("Email iválido! Precisa ter @.");
            }
        }

        public void mostrarCadastro()
        {
            Console.WriteLine("Nome: {0} " +
                "\nCPF: {1} " +
                "\nEmail: {2}" +
                "\nTelefone: {3} ", this.nome, this.cpf, this.email, this.telefone);
        }
    }
}
