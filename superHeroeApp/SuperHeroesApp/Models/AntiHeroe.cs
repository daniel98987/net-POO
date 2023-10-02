using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHeroe: SuperHeroe
    {
        public AntiHeroe()
        {
            
        }
        public string DoingActionOfAntiHeroe(string action)
        {
            return $"Antiheroe {SecretIdentityName} ha realizado: {action}";
        }
    }
}
