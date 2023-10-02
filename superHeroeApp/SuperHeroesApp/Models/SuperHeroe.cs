using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _Name;
        public override string Name { get { return _Name; } set { _Name = value.Trim(); } }
        public int Id { get; set; }
        public string SecretIdentity;
        public string City;
        public List<SuperPower> SuperPowers;
        public bool CanFly;
        public string SecretIdentityName { get { return $"{Name} ({SecretIdentity})"; } set { } }


        public SuperHeroe()
        {
            Id = 1;
            SuperPowers = new List<SuperPower>();
            CanFly = false;



        }
        //Significa que la función va validar internamente algo
        //no retorna nada, solo hace un proceso
        //public void UsingSuperPowers()
        //{
        //    foreach (var power in SuperPowers)
        //    {
        //        Console.WriteLine($"{Name} esta usando el super poder {power.Nombre}!!!!");
        //    }
        //}  
        public string UsingSuperPowers()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var power in SuperPowers)
            {
                sb.AppendLine($"{SecretIdentityName} esta usando el super poder {power.Nombre}!!");
            }
            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{SecretIdentityName} has saved the world ";
        }        
        public override string SavingTheWorld()
        {
            //return base.SavingTheWorld() ;
            return $"{SecretIdentityName} has saved the world";

        }
    }
}
