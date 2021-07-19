using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Departamento.Models;

namespace Departamento
{
    public class Register
    {
        public int Id = 0;
        public string name = string.Empty;
        public decimal value = 0;
        public string Description = string.Empty;
        public void RegisterProduct(List<Produtos> Listaprodutos)
        {
            string resp;
            do
            {
                Register regist = new Register();
                int Id = Listaprodutos.Count() + 1;
                Console.WriteLine("Name of Product:");
                string name = Validacao.IssNotNull();
                Console.WriteLine("Description of Product:");
                string description = Validacao.IssNotNull();
                Console.WriteLine("Value of Product:");
                decimal Value = Validacao.ValueMoney();
                Console.WriteLine("Do you want to register a new product?");
                    do
                    {
                        resp = Validacao.IssNotNull();
                        if (resp != "n" && resp != "s")
                        {
                            ModificaTexto.ColorRed("Invalid Answer! Type Again:");
                        }
                    } while (resp != "n" &&  resp != "s");

            } while (resp == "s");
            Menu.BodyMain();
            Menu.Choise();
        }
        public void RegisterCategory(List<Categorias> ListaCategoria)
        {
            string resp;
            do
            {
                int Id = ListaCategoria.Count() + 1;
                Console.WriteLine("Name of Category:");
                string nameC = Validacao.IssNotNull();
                Console.WriteLine("Description of Category :");
                string descriptionC = Validacao.IssNotNull();
                Console.WriteLine("The amount of Category :");
                int qtd = Convert.ToInt32(Validacao.IntBiggerZero());
                Console.WriteLine("Do you want to register a new Category?");
                do
                {
                    resp = Validacao.IssNotNull();
                    if (resp != "n" && resp != "s")
                    {
                        ModificaTexto.ColorRed("Invalid Answer! Type Again:");
                    }
                } while (resp != "n" && resp != "s");

            } while (resp == "s");
            Menu.BodyMain();
            Menu.Choise();
        }
        public void ReadProducts (List<Produtos> produtos)
        {

        }
    }
}
