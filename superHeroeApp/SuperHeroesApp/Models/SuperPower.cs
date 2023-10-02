using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class SuperPower
    {
        public string Nombre;
        public string Descripcion;
        public PowerNivel Nivel;
        public SuperPower()
        {
            Nivel = PowerNivel.NivelTres;

        }
    }
}
