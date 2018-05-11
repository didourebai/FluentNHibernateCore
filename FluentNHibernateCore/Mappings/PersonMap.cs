using FluentNHibernate.Mapping;
using FluentNHibernateCore.Entities;

namespace FluentNHibernateCore.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id);

            Map(x => x.Name);

            Map(x => x.CreationDate);
            Map(x => x.UpdatedDate);
        }

    }
}
