using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Departamento.Models;


namespace Departamento
{
    public class Menu
    {
        public static List<Categorias> ListCategoria = new List<Categorias>();
        public static List<Produtos> ListaProdutos = new List<Produtos>();
        public static void BodyMain()
        {
            string TamanhoTela;
            Console.Clear();
            TamanhoTela = Departamento.ModificaTexto.CenterText("______________________________________________________________________________________");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("|                                                                                    |");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("|                                  © HAVAN LABS  - 2021                              |");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("|                                                                                    |");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("|____________________________________________________________________________________|");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("______________________________________________________________________________________");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("| [1] - Cadastrar Produto                                                            |");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("| [2] - Cadastrar Categoria                                                          |");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("|____________________________________________________________________________________|");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("______________________________________________________________________________________");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("| [3] - Listagem de Produtos                                                         |");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("| [4] - Listagem de Categorias                                                       |");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("| [0] - Sair do Programa                                                             |");
            Console.Write(TamanhoTela);
            TamanhoTela = Departamento.ModificaTexto.CenterText("|____________________________________________________________________________________|");
            Console.Write(TamanhoTela);
        }
        public static void Choise()
        {
            int choise = 0;
            Register reg = new Register();
            do
            {
                Console.WriteLine("Digite uma das opções acima:");
                try
                {
                    choise = Int32.Parse(Console.ReadLine());
                    if (choise < 0 || choise > 4)
                    {
                        Console.Clear();
                        BodyMain();
                        Console.WriteLine("Somente uma das opções listadas acima");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numero Invalido! Digite um Número Válido:");
                }
            } while (choise < 0 || choise > 4);
            Console.Clear();
            switch (choise)
            {
                case 0:
                    {
                        Console.Clear();
                        ModificaTexto.ColorRed("Aperte qualquer tecla para encerrar o sistema!");
                        break;
                    }
                case 1:
                    {
                        if (ListCategoria.Count() == 0) 
                        {
                            Console.WriteLine("Cadastre uma Nova Categoria antes de Cadastrar um Produto!");
                            Console.ReadLine();
                            BodyMain();
                            Choise();
                        }

                        reg.RegisterProduct(ListaProdutos);
                        Choise();
                        break;
                    }
                case 2:
                    {
                        reg.RegisterCategory(ListCategoria);
                        Choise();
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                default:
                    Console.WriteLine("Erro Desconhecido Consulte o Desenvolvedor do Software!");
                    break;
            }
        }


    }
}
