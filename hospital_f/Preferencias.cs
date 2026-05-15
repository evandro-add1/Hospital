using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_f
{
    internal class Preferencias:Paciente
    {
        public string descricao;
        public string tipo;


        public void cadastrarPreferencia()
        {
            Console.WriteLine("Qual dificulade ");
            tipo = Console.ReadLine();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Descreva o(a) paciente");
                descricao = Console.ReadLine();
                if (!string.IsNullOrEmpty(descricao))
                {
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("A descrição não pode ficar vazia.");
                }
            }
        }

        public void mostrarPreferencia()
        {
            Console.WriteLine("Prioridade pro Ter: {0}", this.tipo);
        }

        public void cuidadosPreferencia()
        {
            Console.WriteLine("Preioridade: {0}" +
                "\nDescrição Para Expecialista: {1}", this.tipo, this.descricao);
        }
    }
}
