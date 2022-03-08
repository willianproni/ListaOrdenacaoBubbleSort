using System;

namespace AgendaLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            int op = 0;
            do
            {
                Console.Clear();
                Menu();
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        agenda.Push(InserirContato());
                        break;
                    case 2:
                        agenda.Print();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
                
            } while (op != 0);
        }

        public static void Menu()
        {
            Console.WriteLine("------ Menu ------" +
                              "\n[1] - Cadastrar Contato" +
                              "\n[2] - Mostrar Contatos" +
                              "\n[0] - Fechar" +
                              "\n------------------");
            Console.Write("Opção: ");
        }

        public static Contato InserirContato()
        {
            Console.Clear();
            Console.WriteLine("----- Cadastro de Contato -----");
            Console.Write("Nome do Contato: ");
            string nome = Console.ReadLine();
            Console.Write("\nEmail do Contato: ");
            string email = Console.ReadLine();
            Console.Write("\nTipo do Telefone (casa, celular, trabalho...): ");
            string tipo = Console.ReadLine();
            Console.Write("\nDDD: ");
            string ddd = Console.ReadLine();
            Console.Write("\nTelefone: ");
            string telefone = Console.ReadLine();
            Contato aux = new Contato(nome, email, new Telefone(tipo, ddd, telefone));
            Console.WriteLine("Contato Adicionado com Sucesso!!");
            Console.ReadKey();
            return aux;
            
        }
    }
}
