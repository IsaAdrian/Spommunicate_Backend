using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSportCommManager
{
    public class SportManager
    {
        public SportRepository<Person> RepPerson { get; } = new SportRepository<Person>();
        public SportRepository<Chat> RepChat { get; } = new SportRepository<Chat>();
        public SportRepository<PersonChat> RepPersonChat { get; } = new SportRepository<PersonChat>();
    }
}
