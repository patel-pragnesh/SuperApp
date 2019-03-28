using System.Collections.Generic;

namespace SuperApp.Models
{
    public class Hero
    {
        public string Id { get; set; }
        public string Alias { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
