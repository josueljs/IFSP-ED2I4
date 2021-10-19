using System;
using System.Collections.Generic;

namespace Atividade21_10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuexit = false;
            string choice;
            int num;
            
            Contatos agenda = new Contatos();

            Console.WriteLine("Bem vindo!");
            Console.WriteLine("");

            while (!menuexit)
            {
                Console.WriteLine("");
                Console.WriteLine("-|-|-|-|-|-|-|-|-|-|-");
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Pesquisar contato");
                Console.WriteLine("3. Alterar contato");
                Console.WriteLine("4. Remover contato");
                Console.WriteLine("5. Listar contatos");
                Console.WriteLine("");

                do
                {
                    Console.WriteLine("Digite a opção desejada: ");
                    choice = Console.ReadLine();
                    Console.WriteLine("");
                } while (!Int32.TryParse(choice, out num) || num < 0 || num > 5);

                Console.WriteLine("");

                switch (num)
                {
                    case 0:
                        menuexit = true;
                        break;

                    case 1:
                        AdicionarContato();
                        break;

                    case 2:
                        PesquisarContato();
                        break;

                    case 3:
                        AlterarContato();
                        break;

                    case 4:
                        RemoverContato();
                        break;

                    case 5:
                        ListarContatos();
                        break;
                }
            }

            Console.WriteLine("Obrigado e volte sempre!");
            Console.WriteLine("");

            Console.ReadKey();

            void AdicionarContato(){
                string email, nome, telefone, choice;
                int dia, mes, ano;

                Console.WriteLine("Adicionando um contato...");

                Console.WriteLine("Digite o email do contato: ");
                email = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Digite o nome do contato: ");
                nome = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Digite o telefone do contato: ");
                telefone = Console.ReadLine();
                Console.WriteLine("");

                do
                {
                    Console.WriteLine("Digite o ano de nascimento do contato: ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out ano) || ano < 1900 || ano > 2021);
                Console.WriteLine("");

                do
                {
                    Console.WriteLine("Digite o mês de nascimento do contato: ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out mes) || mes < 1 || mes > 12);
                Console.WriteLine("");

                do
                {
                    Console.WriteLine("Digite o dia de nascimento do contato: ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out dia) || dia < 1 || dia > 31);
                Console.WriteLine("");

                Data data = new Data();
                data.setData(dia, mes, ano);

                Contato contato = new Contato(email, nome, telefone, data);

                agenda.adicionar(contato);

                Console.WriteLine("Contato adicionado!");
                Console.WriteLine("");

            }

            void PesquisarContato()
            {
                string email;

                Console.WriteLine("Pesquisando um contato (pelo email)...");

                Console.WriteLine("Digite o email que deseja pesquisar: ");
                email = Console.ReadLine();
                Console.WriteLine("");

                Contato contatoprocurado = new Contato();
                contatoprocurado.Email = email;

                if (agenda.pesquisar(contatoprocurado).Email != "")
                {
                    Console.WriteLine("Contato encontrado: " + (agenda.pesquisar(contatoprocurado)).ToString());
                }
                else
                {
                    Console.WriteLine("Nenhum contato encontrado com o email digitado!");
                }
                Console.WriteLine("");
            }

            void AlterarContato()
            {
                string email, nome, telefone, choice;
                int dia, mes, ano;

                Console.WriteLine("Alterando um contato...");

                Console.WriteLine("Digite o email do contato que deseja alterar: ");
                email = Console.ReadLine();
                Console.WriteLine("");

                Contato contatoprocurado = new Contato();
                contatoprocurado.Email = email;

                if (agenda.pesquisar(contatoprocurado).Email != "")
                {
                    Console.WriteLine("Contato encontrado: " + (agenda.pesquisar(contatoprocurado)).ToString());

                    Console.WriteLine("Digite o nome do contato: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("Digite o telefone do contato: ");
                    telefone = Console.ReadLine();
                    Console.WriteLine("");

                    do
                    {
                        Console.WriteLine("Digite o ano de nascimento do contato: ");
                        choice = Console.ReadLine();
                    } while (!Int32.TryParse(choice, out ano) || ano < 1900 || ano > 2021);
                    Console.WriteLine("");

                    do
                    {
                        Console.WriteLine("Digite o mês de nascimento do contato: ");
                        choice = Console.ReadLine();
                    } while (!Int32.TryParse(choice, out mes) || mes < 1 || mes > 12);
                    Console.WriteLine("");

                    do
                    {
                        Console.WriteLine("Digite o dia de nascimento do contato: ");
                        choice = Console.ReadLine();
                    } while (!Int32.TryParse(choice, out dia) || dia < 1 || dia > 31);
                    Console.WriteLine("");

                    Data data = new Data();
                    data.setData(dia, mes, ano);

                    Contato contato = new Contato(email, nome, telefone, data);

                    agenda.alterar(contato);

                    Console.WriteLine("Contato alterado!");

                }
                else
                {
                    Console.WriteLine("Nenhum contato encontrado com o email digitado! Cancelando a operação...");
                }

            }

            void RemoverContato()
            {
                string email;

                Console.WriteLine("Removendo um contato...");
                Console.WriteLine("Digite o email do contato que deseja remover: ");
                email = Console.ReadLine();
                Console.WriteLine("");

                Contato contatoprocurado = new Contato();
                contatoprocurado.Email = email;

                if (agenda.pesquisar(contatoprocurado).Email != "")
                {
                    Console.WriteLine("Contato encontrado: " + (agenda.pesquisar(contatoprocurado)).ToString());

                    agenda.remover(contatoprocurado);

                    Console.WriteLine("Contato removido!");
                }
                else
                {
                    Console.WriteLine("Nenhum contato encontrado com o email digitado! Cancelando a operação...");
                }
                Console.WriteLine("");

            }

            void ListarContatos()
            {
                Console.WriteLine("Listando todos os contatos adicionados...");
                agenda.mostraLista();
                Console.WriteLine("");
            }
        }
    }
}
