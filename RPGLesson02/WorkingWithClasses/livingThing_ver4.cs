using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    class livingThing_ver4
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
                    case "Human":
                    case "human":
                    case "HUMAN":
                        race = value;
                        break;
                    case "Elf":
                    case "elf":
                    case "ELF":
                        race = value;
                        break;
                    case "Dwarf":
                    case "dwarf":
                    case "DWARF":
                        race = value;
                        break;
                    case "Hobbit":
                    case "hobbit":
                    case "HOBBIT":
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
                switch (race)
                {
                    case "Human":
                    case "human":
                    case "HUMAN":
                        if ((value >=5) && (value <=18))
                        {
                            strength = value;
                        }
                        else
                        {
                            strength = 5;
                        }
                        break;
                    case "Elf":
                    case "elf":
                    case "ELF":
                        value = value - 2;
                        if ((value >= 5) && (value <= 16))
                        {
                            strength = value;
                        }
                        else
                        {
                            strength = 5;
                        }
                        break;
                    case "Dwarf":
                    case "dwarf":
                    case "DWARF":
                        value = value + 5;
                        if ((value >= 8) && (value <= 23))
                        {
                            strength = value;
                        }
                        else
                        {
                            strength = 8;
                        }
                        break;
                    case "Hobbit":
                    case "hobbit":
                    case "HOBBIT":
                        value = value - 4;
                        if ((value >= 5) && (value <= 14))
                        {
                            strength = value;
                        }
                        else
                        {
                            strength = 5;
                        }
                        break;
                    default:
                        Console.WriteLine("Race does not exist so no modifiers added");
                        return;
                }
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
                switch (race)
                {
                    case "Human":
                    case "human":
                    case "HUMAN":
                        if ((value >= 3) && (value <= 18))
                        {
                            dexterity = value;
                        }
                        else
                        {
                            dexterity = 5;
                        }
                        break;
                    case "Elf":
                    case "elf":
                    case "ELF":
                        value = value + 6;
                        if ((value >= 9) && (value <= 24))
                        {
                            dexterity = value;
                        }
                        else
                        {
                            dexterity = 9;
                        }
                        break;
                    case "Dwarf":
                    case "dwarf":
                    case "DWARF":
                        value = value - 5;
                        if ((value >= 5) && (value <= 13))
                        {
                            dexterity = value;
                        }
                        else
                        {
                            dexterity = 5;
                        }
                        break;
                    case "Hobbit":
                    case "hobbit":
                    case "HOBBIT":
                        value = value + 6;
                        if ((value >= 7) && (value <= 25))
                        {
                            dexterity = value;
                        }
                        else
                        {
                            dexterity = 7;
                        }
                        break;
                    default:
                        Console.WriteLine("Race does not exist so no modifiers added");
                        return;
                }
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
                switch (race)
                {
                    case "Human":
                    case "human":
                    case "HUMAN":
                        if ((value >= 3) && (value <= 18))
                        {
                            intelligence = value;
                        }
                        else
                        {
                            intelligence = 3;
                        }
                        break;
                    case "Elf":
                    case "elf":
                    case "ELF":
                        value = value + 7;
                        if ((value >= 8) && (value <= 26))
                        {
                            intelligence = value;
                        }
                        else
                        {
                            intelligence = 8;
                        }
                        break;
                    case "Dwarf":
                    case "dwarf":
                    case "DWARF":
                        value = value - 2 ;
                        if ((value >= 5) && (value <= 16))
                        {
                            intelligence = value;
                        }
                        else
                        {
                            intelligence = 5;
                        }
                        break;
                    case "Hobbit":
                    case "hobbit":
                    case "HOBBIT":
                        if ((value >= 3) && (value <= 18))
                        {
                            intelligence = value;
                        }
                        else
                        {
                            intelligence = 3;
                        }
                        break;
                    default:
                        Console.WriteLine("Race does not exist so no modifiers added");
                        return;
                }
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
                switch (race)
                {
                    case "Human":
                    case "human":
                    case "HUMAN":
                        if ((value >= 3) && (value <= 18))
                        {
                            constitution = value;
                        }
                        else
                        {
                            constitution = 3;
                        }
                        break;
                    case "Elf":
                    case "elf":
                    case "ELF":
                        value = value - 2;
                        if ((value >= 3) && (value <= 16))
                        {
                            constitution = value;
                        }
                        else
                        {
                            constitution = 3;
                        }
                        break;
                    case "Dwarf":
                    case "dwarf":
                    case "DWARF":
                        value = value + 5;
                        if ((value >= 8) && (value <= 23))
                        {
                            constitution = value;
                        }
                        else
                        {
                            constitution = 8;
                        }
                        break;
                    case "Hobbit":
                    case "hobbit":
                    case "HOBBIT":
                        if ((value >= 3) && (value <= 18))
                        {
                            constitution = value;
                        }
                        else
                        {
                            constitution = 3;
                        }
                        break;
                    default:
                        Console.WriteLine("Race does not exist so no modifiers added");
                        return;
                }
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
                switch (race)
                {
                    case "Human":
                    case "human":
                    case "HUMAN":
                        if ((value >= 3) && (value <= 18))
                        {
                            charisma = value;
                        }
                        else
                        {
                            charisma = 3;
                        }
                        break;
                    case "Elf":
                    case "elf":
                    case "ELF":
                        value = value + 5;
                        if ((value >= 6) && (value <= 23))
                        {
                            charisma = value;
                        }
                        else
                        {
                            charisma = 6;
                        }
                        break;
                    case "Dwarf":
                    case "dwarf":
                    case "DWARF":
                        value = value - 3;
                        if ((value >= 3) && (value <= 15))
                        {
                            charisma = value;
                        }
                        else
                        {
                            charisma = 3;
                        }
                        break;
                    case "Hobbit":
                    case "hobbit":
                    case "HOBBIT":
                        value = value + 4;
                        if ((value >= 5) && (value <= 23))
                        {
                            charisma = value;
                        }
                        else
                        {
                            charisma = 5;
                        }
                        break;
                    default:
                        Console.WriteLine("Race does not exist so no modifiers added");
                        return;
                }
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
                switch (race)
                {
                    case "Human":
                    case "human":
                    case "HUMAN":
                        if ((value >= 3) && (value <= 18))
                        {
                            wisdom = value;
                        }
                        else
                        {
                            wisdom = 3;
                        }
                        break;
                    case "Elf":
                    case "elf":
                    case "ELF":
                        value = value + 5;
                        if ((value >= 6) && (value <= 23))
                        {
                            wisdom = value;
                        }
                        else
                        {
                            wisdom = 6;
                        }
                        break;
                    case "Dwarf":
                    case "dwarf":
                    case "DWARF":
                        value = value - 3;
                        if ((value >= 3) && (value <= 15))
                        {
                            wisdom = value;
                        }
                        else
                        {
                            wisdom = 3;
                        }
                        break;
                    case "Hobbit":
                    case "hobbit":
                    case "HOBBIT":
                        value = value - 3;
                        if ((value >= 3) && (value <= 23))
                        {
                            wisdom = value;
                        }
                        else
                        {
                            wisdom = 3;
                        }
                        break;
                    default:
                        Console.WriteLine("Race does not exist so no modifiers added");
                        return;
                }
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

