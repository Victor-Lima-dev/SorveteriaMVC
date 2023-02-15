using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sorveteriaMVC.Models
{
    public class Sorvete
    {
        public int SorveteId { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Sabor { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }


        
    }
}