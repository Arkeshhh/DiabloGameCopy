using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC1.character
{
    class BaseStats
    {
        private string CharacterName { get; }
        private int HealthPoints { get; set; }
        private int ManaPoints { get; set; }
        private int AD { get; set; } // Attack damage (physical)
        private int AP { get; set; } // Ability power (magic)
        private int Agility { get; set; }

        public BaseStats(string charactername, int health, int mana, int agility, int ad, int ap)
        {
            CharacterName = charactername;  
            HealthPoints = health;  
            ManaPoints = mana;
            Agility = agility;
            AD = ad;    
            AP = ap;        
        }
    }
}
