using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_f
{
    internal class Program
    {
        static void Main()
        {
            //Para salvar
            Paciente[] pacienteF = new Paciente[100];

            int totalPacientes = 0;

            //opção
            int opcao = 0;

            //Seleção
            while (opcao != 5)
            {

                Console.WriteLine("teste");

                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine(" ║              MENU DE CADASTRO                ║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");
                Console.WriteLine(" ║ 1 - Cadastrar Pacientes                      ║");
                Console.WriteLine(" ║ 2 - Mostrar Dados                            ║");
                Console.WriteLine(" ║ 3 - Deletar Cadastro                         ║");
                Console.WriteLine(" ║ q - Sair                                     ║");
                Console.WriteLine("╚════════════════════════════════════════════════╝");

                Console.Write("Escolha uma opção: ");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    // para opcao funcionar
                    case 1:
                        Paciente p = new Paciente();
                        p.cadastrarP();



                        break;

                    case 2:
                        break;

                }
                break;
            }

            if (opcao != 5)
            {
                Console.WriteLine("\n╔════════════════════════════════════════════════╗");
                Console.WriteLine(" ║Pressione qualquer tecla para voltar ao menu..║");
                Console.WriteLine("╠════════════════════════════════════════════════╣");

                Console.WriteLine("");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
