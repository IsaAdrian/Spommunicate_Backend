using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportComm.Dtos
{
    public class PersonDtos
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
   public class SaisonDto
    {
        public int SaisonId { get; set; }
        public int Strength { get; set; }
    }
    public class MatchDto
    {
        public int MatchId { get; set; }
        public int Strength { get; set; }
        public string Team { get; set; }
    }

    public static class Extensions
    {
        public static PersonDtos ToDto(this Pupil pupil)
        {
            return new PupilDto
            {
                Firstname = pupil.Firstname,
                Lastname = pupil.Lastname,
                Birthday = pupil.Birthday.ToShortDateString(),
                PupilId = pupil.PupilId
            };
        }
    }
}