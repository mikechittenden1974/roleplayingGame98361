using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    class Barbarian: livingThing_Ver5
    {
        public override int getArmour()
        {
            return 20 - Dexterity/2;
        }
    }
}
