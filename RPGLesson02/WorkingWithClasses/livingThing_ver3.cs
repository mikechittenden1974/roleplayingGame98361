using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    class livingThing_ver3
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

        //Properties

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if ((value != null) || (value != ""))
                    name = value;
            }
        }


        public string Race
        {
            get
            {
                return race;
            }
            set
            {
                switch (value)
                {
                    case "HUMAN":
                    case "Human":
                    case "human":
                        race = value;
                        break;
                    case "elf":
                        race = value;
                        break;
                    case "dwarf":
                        race = value;
                        break;
                    case "hobbit":
                        race = value;
                        break;
                    default:
                        Console.WriteLine("Race is not known");
                        return;
                }

            }
        }  

    public string Profession
    {
        get
        {
            return profession;
        }
        set
        {
            if ((value != null) || (value != ""))
                profession = value;
        }
    }

    public int Strength
    {
        get
        {
            return strength;
        }
        set
        {
            if ((value > 2) && (value < 19))
                strength = value;
        }
    }

    public int Dexterity
    {
        get
        {
            return dexterity;
        }
        set
        {
            if ((value > 2) && (value < 19))
                dexterity = value;
        }
    }

    public int Intelligence
    {
        get
        {
            return intelligence;
        }
        set
        {
            if ((value > 2) && (value < 19))
                intelligence = value;
        }
    }

    public int Constitution
    {
        get
        {
            return constitution;
        }
        set
        {
            if ((value > 2) && (value < 19))
                constitution = value;
        }
    }

    public int Charisma
    {
        get
        {
            return charisma;
        }
        set
        {
            if ((value > 2) && (value < 19))
                charisma = value;
        }
    }

    public int Wisdom
    {
        get
        {
            return wisdom;
        }
        set
        {
            if ((value > 2) && (value < 19))
                wisdom = value;
        }
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
        Console.WriteLine("\tHealth:\t\t\t{0}", getHealth());
        Console.WriteLine("\tArmour:\t\t\t{0}\n", getArmour());
        Console.WriteLine("\tMagic Points:\t\t{0}", getMagic());
        Console.WriteLine("\tLuck:\t\t\t{0}", getLuck());
        }
}
}

