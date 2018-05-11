using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernateCore.Entities;

namespace FluentNHibernateCore.Services
{
    public class TaskService
    {
        public static void GetTaskInfo(Task task)

        {

            Console.WriteLine(task.Title);
            Console.WriteLine(task.Description);
            Console.WriteLine(task.State);
            Console.WriteLine(task.AssignedTo.Name);


            Console.WriteLine();

        }
    }
}
