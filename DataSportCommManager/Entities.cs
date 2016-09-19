using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSportCommManager
{
    public class Person
    {
        public int PersonId { get; set; }
        public bool IsTrainer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<PersonChat> PersonChats { get; set; }
    }
    public class PersonChat
    {
        public Person Person { get; set; }
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Chat Chat { get; set; }
        [ForeignKey("Chat")]
        public int ChatId { get; set; }
    }
    public class Chat
    {
        public int ChatId { get; set; }
        public virtual ICollection<PersonChat> PersonChats { get; set; }
        public virtual ICollection<Message> Messages { get; set; }

    }
    public class Message
    {
        public int MessageId { get; set; }
        public string Text { get; set; }

    }
    public class Trainingsplan
    {
        public int TrainingsplanId { get; set; }
        public List<Training> Trainings { get; set; }

    }
    public class Training
    {
        public int TrainingId { get; set; }
        public string Bezeichnung { get; set; }
        public string Info { get; set; }
        public object Video { get; set; }
    }
    public class Saison
    {
        public int SaisonId { get; set; }
        public string Name { get; set; }
        public virtual List<Match> Matches { get; set; }

    }
    public class Match
    {
        public int MatchId { get; set; }
        public int Strength { get; set; }
        public string Team { get; set; }
    }
}
