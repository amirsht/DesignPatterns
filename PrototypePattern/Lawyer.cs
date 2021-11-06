namespace PrototypePattern
{
    public class Lawyer : IEmployee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Court { get; set; }

        public IEmployee Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (IEmployee)MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (IEmployee)this.Clone();
        }

        public string GetDetails() => $"{Name}, {Role}, {Court}";
    }
}
