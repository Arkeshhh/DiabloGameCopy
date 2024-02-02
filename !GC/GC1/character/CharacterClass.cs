using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC1.character
{
    class CharacterClass : BaseStats
    {
        private string ClassName { get; set; } //
        public CharacterClass(string charactername, int health, int mana, int agility, int ad, int ap, string className) : base(charactername, health, mana, agility, ad, ap)
        {
            ClassName = className;
        }

        public void SelectWarrior()
        {
            CharacterClass Warrior = new CharacterClass("-", 70, 10, 20, 30, 10, "Warrior");        
        }

        public void SelectArcher()
        {
            CharacterClass Rogue = new CharacterClass("-", 45, 22, 30, 20, 15, "Rogue");
        }

        public void SelectSorcerer()
        {
            CharacterClass Sorcerer = new CharacterClass("-", 30, 70, 15, 15, 35, "Rogue");
        }
    }
}
