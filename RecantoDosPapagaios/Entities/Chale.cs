using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace RecantoDosPapagaios.Entities
{
    //CLASSE CHALES CRIADA PARA TESTE
    class Chale
    {
        public string Status { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Categoria;
        public Image Foto { get; set; }
        public int LimiteHospede { get; set; }
        public double MetrosQuadrados { get; set; }
        public string TipoCama{ get; set; }
        public double ValorDiaria { get; set; }


        public List<Chale> ListaChales { get; set; } = new List<Chale>();

        public Chale()
        {
        }

        public Chale(int id, string nome, Image foto, 
            int limiteHospede, double metrosQuadrados, string tipoCama, double valorDiaria)
        {
            Id = id;
            Nome = nome;
            Foto = foto;
            LimiteHospede = limiteHospede;
            MetrosQuadrados = metrosQuadrados;
            TipoCama = tipoCama;
            ValorDiaria = valorDiaria;
        }

    }
}
