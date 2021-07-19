using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departamento.Models
{
    public class Categorias : BaseModels
    {
        //created a public sealed class with ctrl + .
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }

        public Categorias(int id, string name, string descripton)
        {
            this.Id = id;
            this.Name = name;
            this.Description = descripton;        
        }
    }
}
