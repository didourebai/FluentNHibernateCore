# FluentNHibernateCore



NHibernate is an object-relational mapping (ORM) framework, it allow you to map the object oriented domain model with the tables in a relational Database. To realize the
mapping, we have to write XML mapping files (.hbm.xml files), and to make it easier, here comes Fluent NHibernate as an abstraction layer to do it in C#
rather than XML.

When Microsoft started working on the framework Core, much functionality in NHibernate wasn’t supported in .NET Core as target platform, but from the version Core 2.0, we can integration
NHibernate even Fluent NHibernate. 

In this project , I will show the use of Fluent NHibernate in the framework Core 2.0

In this sample, we use the same entities when we worked with Entity Framework to display the difference between them.
Person Entity and Task Entity.
