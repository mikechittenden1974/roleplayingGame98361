using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    class livingThing_ver2
    {
        //Set data members
        private string name;
        private string race;
        private string profession;

        private int strength;
        private int dexterity;
        private int intelligence;
        private int constitution;
        private int charisma;
        private int wisdom;

        public livingThing_ver2(string n, string r, string p, int s, int d, int intel, int c, int ch, int w)
        {
            name = n;
            race = r;
            profession = p;
            strength = s;
            dexterity = d;
            intelligence = intel;
            constitution = c;
            charisma = ch;
            wisdom = w;
        }

        //Methods
        public double getHealth()
        {
            return (strength + (0.5 * constitution)) * 2;
        }

        public int getArmour()
        {
            return 10 - (dexterity / 2);
        }

        public int getMagic()
        {
            return (4 * intelligence);
        }

        public int getLuck()
        {
            Random l = new Random();
            return l.Next(0, 9);
        }

        public void Display()
        {
            Console.WriteLine("Name :  {0}\t\tRace : {1}\t\tProfession: {2}", name, race, profession);
            Console.WriteLine("\tStrength:\t\t{0}", strength);
            Console.WriteLine("\tDexterity:\t\t{0}", dexterity);
            Console.WriteLine("\tIntelligence:\t\t{0}", intelligence);
            Console.WriteLine("\tConstitution:\t\t{0}", constitution);
            Console.WriteLine("\tCharisma:\t\t{0}", charisma);
            Console.WriteLine("\tWisdom:\t\t\t{0}\n", wisdom);
        }
    }
}
