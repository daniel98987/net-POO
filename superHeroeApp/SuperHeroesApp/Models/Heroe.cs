using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal abstract class Heroe
    {
        public abstract string Name { get; set; }
        public abstract string SalvarElMundo();
        //VIRTUAL ACTUA COMO POLIMORFISMO, ESTOO PUEDE SER MODIFICADO EN OTRO PARTE
        //SI SE REQUIERE
        public virtual string SavingTheWorld()
        {
            return $"{Name} has saved the world";
        }

      
    }
}
