using DataSportCommManager;
using SportComm.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SportComm.Controllers
{
    [EnableCors("*", "*", "*")]
    public class PersonController : ApiController
    {
        EFRepository<Person, SportContext> repo = new EFRepository<Person, SportContext>();
        public IEnumerable<PersonDtos> Get()
        {

                return repo.Get().Select(p => p.ToDto()).ToList();
            
        }
    }
}
