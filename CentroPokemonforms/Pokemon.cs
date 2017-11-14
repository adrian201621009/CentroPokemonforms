using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroPokemonforms
{
   
           public enum tipotipo
        {
            fuego,
            agua,
            tierra,
            planta,
        }
        public enum tipoesatados
        {
            envenenado,
            somnoliento,
            paralizado,
            congelado,
            quemado,
        }
        public enum pokerus
        {
            si,
            no,
        }

        public class Pokemon
        {
            public int Numero { get; set; }
            public string Nombre { get; set; }
            public int Hp { get; set; }
            public tipotipo Tipo { get; set; }
            public tipoesatados Estado { get; set; }
            public pokerus Pokeruss { get; set; }
        }
    }

