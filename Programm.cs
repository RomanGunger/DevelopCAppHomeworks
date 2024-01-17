using System;

namespace OOP_Lesson_01
{
    class Programm
    {
        static void Main(string[] args)
        {
            var grandMother = new FamilyMember()
                { Mother = null, Father = null, Name = "Velery", Sex = Gender.Female, BirthDay = new DateTime(1968, 03, 15) };
            var grandFather = new FamilyMember()
                { Mother = null, Father = null, Name = "Bob", Sex = Gender.Male, BirthDay = new DateTime(1968, 03, 15) };
            var father = new FamilyMember()
                { Mother = grandMother, Father = grandFather, Name = "John", Sex = Gender.Male, BirthDay = new DateTime(1993, 01, 13) };
            var mother = new FamilyMember()
                { Mother = null, Father = null, Name = "Amily", Sex = Gender.Female, BirthDay = new DateTime(1993, 07, 24) };
            var son1 = new FamilyMember()
            { Mother = mother, Father = father, Name = "Kriss", Sex = Gender.Male, BirthDay = new DateTime(2015, 11, 05) };
            var mother1 = new FamilyMember()
            { Mother = null, Father = null, Name = "Amily", Sex = Gender.Female, BirthDay = new DateTime(1993, 07, 24) };

            var son2 = new FamilyMember()
            { Mother = mother, Father = father, Name = "Joshua", Sex = Gender.Male, BirthDay = new DateTime(2015, 12, 01) };
            var mother2 = new FamilyMember()
            { Mother = null, Father = null, Name = "Amily", Sex = Gender.Female, BirthDay = new DateTime(1993, 07, 24) };

            var son21 = new FamilyMember()
            { Mother = mother1, Father = son1, Name = "Joshua", Sex = Gender.Male, BirthDay = new DateTime(2015, 12, 01) };
            var son22 = new FamilyMember()
            { Mother = mother2, Father = son2, Name = "Joshua", Sex = Gender.Male, BirthDay = new DateTime(2015, 12, 01) };
            var son23 = new FamilyMember()
            { Mother = mother2, Father = son2, Name = "Joshua", Sex = Gender.Male, BirthDay = new DateTime(2015, 12, 01) };

            grandFather.Spouse = grandMother;
            grandFather.Children = new FamilyMember[] { father };

            father.Children = new FamilyMember[] { son1, son2 };
            father.Spouse = mother;

            son1.Children = new FamilyMember[] { son21 };

            son2.Children = new FamilyMember[] { son22, son23 };

            Console.WriteLine(grandFather.PrintFamilyMember());
        }
    }
}

