using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    public class PersonalBests
    {
        public int Place { get; set; }

        public Run Run { get; set; }

        public Game Game { get; set; }

        public Category Category { get; set; }

        public Level Level { get; set; }

        public List<User> PlayerUsers { get; set; }

        public Region Region { get; set; }

        public Platform Platform { get; set; }

        internal PersonalBests() { }
    }
}
