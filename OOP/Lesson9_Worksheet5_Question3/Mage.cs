using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Worksheet5_Question3
{
    


    class Mage : Character
    {
        public Mage(): base(100, 300, 75)
        { }

        public override void Attack(Character character)
        {
            //But when the Mage attacks, he uses 100 mana and deals twice his default damage. 

            Mana -= 100;
            character.Health += (Damage * 2);

        }
    }
}
