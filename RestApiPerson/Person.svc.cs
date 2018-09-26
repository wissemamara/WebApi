using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestApiPerson
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Person" in code, svc and config file together.
    public class Person : IPerson
    {
        public void DoWork()
        {
        }

        public List<Person> findAll()
        {
            using(PersonDBEntities mde=new PersonDBEntities()){
                return mde.PersonEntity.
              

            };
        }

        public Person find(int Id)
        {
            throw new NotImplementedException();
        }

        public bool create(Person person)
        {
            throw new NotImplementedException();
        }

        public bool edit(Person person)
        {
            throw new NotImplementedException();
        }

        public bool delete(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
