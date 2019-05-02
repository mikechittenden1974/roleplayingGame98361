using System;

namespace WorkingWithClasses
{
    class Program
    {

        static void Main(string[] args)
        {
            //Start by creating an object of livingThing_ver1

            livingThing_ver1 obj = new livingThing_ver1("Legolas", "Elf", "Archer", 16, 14, 16, 20, 14, 21, 16, 2, 16, 19);
            obj.Display();

            livingThing_ver2 obj2 = new livingThing_ver2("Gimli", "Dwarf", "Fighter", 18, 12, 12, 18, 9, 9);
            Console.WriteLine("\n");
            obj2.Display();
            Console.WriteLine("\tHealth:\t\t\t{0}", obj2.getHealth());
            Console.WriteLine("\tArmour:\t\t\t{0}\n", obj2.getArmour());
            Console.WriteLine("\tMagic Points:\t\t{0}", obj2.getMagic());
            Console.WriteLine("\tLuck:\t\t\t{0}", obj2.getLuck());

            livingThing_ver3 obj3 = new livingThing_ver3();
            Console.WriteLine("\n");
            obj3.Name = "Boromir";
            obj3.Race = "Human";
            obj3.Profession = "Fighter";
            obj3.Strength = 18;
            obj3.Dexterity = 14;
            obj3.Intelligence = 12;
            obj3.Constitution = 16;
            obj3.Charisma = 10;
            obj3.Wisdom = 9;
            obj3.Display();

            livingThing_ver4 obj4 = new livingThing_ver4();
            Console.WriteLine("\n");
            obj4.Name = "Frodo";
            obj4.Race = "Hobbit";
            obj4.Profession = "Thief";
            obj4.Strength = 3;
            obj4.Dexterity = 14;
            obj4.Intelligence = 12;
            obj4.Constitution = 8;
            obj4.Charisma = 16;
            obj4.Wisdom = 12;
            obj4.Display();

            Barbarian obj5 = new Barbarian();
            obj5.Name = "Conan";
            obj5.Race = "Human";
            obj5.Profession = "Barbarian";
            obj5.Strength = 17;
            obj5.Dexterity = 14;
            obj5.Intelligence = 8;
            obj5.Constitution = 17;
            obj5.Charisma = 10;
            obj5.Wisdom = 12;
            obj5.Display();
            obj5.Display();

        }
    }
}
