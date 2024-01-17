namespace OOP_Lesson_01
{
    public class FamilyMember
    {
        public FamilyMember? Mother { get; set; }
        public FamilyMember? Father { get; set; }
        public FamilyMember[]? Children { get; set; }
        public FamilyMember? Spouse { get; set; }
        public string Name { get; set; } = string.Empty;
        public Gender Sex { get; set; }
        public DateTime BirthDay { get; set; }

        public string PrintFamilyMember(int indent = 2)
        {
            string childrens = string.Empty;
            if (Children?.Length > 0)
            {
                foreach (FamilyMember member in Children)
                {
                    childrens += new String('-', indent) + member.PrintFamilyMember(indent + 2);
                }
            }

            string parrents = string.Empty;
            if (Mother != null)
                parrents += $"Mother: {Mother?.Name}";
            if (Father != null)
                parrents += $" |Father: {Father?.Name}";

            string spouse = string.Empty;
            if (Spouse != null)
                spouse += $"Spouce: {Spouse?.Name}| ";

            return $"Name: {Name}| Sex: {Sex}| Birthday: {BirthDay}| {spouse}{parrents}\n{childrens}";
        }
    }
}