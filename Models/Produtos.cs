using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departamento.Models
{
    public class Produtos : BaseModels
    {
        [Key]
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Qtd { get; set; }
        public Categorias Categoria { get; set; }
        public Produtos(int id, string name, decimal value, int qtd, Categorias categorias)
        {
            this.Categoria = categorias;
            this.Id = id;
            this.Name = name;
            this.Value = value;
            this.Qtd = qtd;
        }
    }
}
