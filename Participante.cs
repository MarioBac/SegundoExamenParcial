using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundoExamenParcial
{
    public class Participante
    {
        public string nombre { get;set;}

        public string genero { get; set; }

        public int Experiencia { get; set; }

        public List <Videojuego> VideojuegoList { get; set; }
    }
}