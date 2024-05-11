using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PersonBusiness
    {
        public List<Person> Get()
        {
            PersonData data = new PersonData();
            var people = data.Get();
            return people;
        }
        public List<Person> Get18()
        {
            PersonData data = new PersonData();
            var people = data.Get();
            var result = people.Where(x=>x.Age > 18).ToList();
            return result;
        }

    }
}
