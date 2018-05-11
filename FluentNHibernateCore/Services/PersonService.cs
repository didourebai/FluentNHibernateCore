using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernateCore.Entities;

namespace FluentNHibernateCore.Services
{
    public class PersonService
    {
        public  static void GetPerson(Person person)

        {

            Console.WriteLine(person.Name);

            Console.WriteLine();

        }
        

    }
}
