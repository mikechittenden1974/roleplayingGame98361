using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    class livingThing_ver1
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

        private int health;
        private int armour;
        private int magicPoints;
        private int luck;

        //Set Constructor

        public livingThing_ver1(string n, string r, string p, int s, int d, int intel, int c, int ch, int w, int h, int a, int m, int l)
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
            health = h;
            armour = a;
            magicPoints = m;
            luck = l;
        }

        //Methods
        public void Display()
        {
            Console.WriteLine("Name :  {0}\t\tRace : {1}\t\tProfession: {2}", name, race, profession);
            Console.WriteLine("\tStrength:\t\t{0}",strength);
            Console.WriteLine("\tDexterity:\t\t{0}", dexterity);
            Console.WriteLine("\tIntelligence:\t\t{0}", intelligence);
            Console.WriteLine("\tConstitution:\t\t{0}", constitution);
            Console.WriteLine("\tCharisma:\t\t{0}", charisma);
            Console.WriteLine("\tWisdom:\t\t\t{0}\n", wisdom);
            Console.WriteLine("\tHealth:\t\t\t{0}", health);
            Console.WriteLine("\tArmour:\t\t\t{0}\n", armour);
            Console.WriteLine("\tMagic Points:\t\t{0}", magicPoints);
            Console.WriteLine("\tLuck:\t\t\t{0}", luck);
        }
    }
}
