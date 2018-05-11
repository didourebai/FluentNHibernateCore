using System;

namespace FluentNHibernateCore.Entities
{
    public class Task
    {
        public virtual string Id { get; set; }
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public virtual TaskState State { get; set; }

        public virtual Person AssignedTo { get; set; }

        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime UpdatedDate { get; set; }

        public Task()
        {
            CreationTime = DateTime.UtcNow;
            State = TaskState.Open;
        }

    }

    public enum TaskState : byte
    {
        /// <summary>
        /// The task is Open.
        /// </summary>
        Open = 0,
        /// <summary>
        /// The task is active.
        /// </summary>
        Active = 1,

        /// <summary>
        /// The task is completed.
        /// </summary>
        Completed = 2,

        /// <summary>
        /// The task is closed.
        /// </summary>
        Closed = 3
    }
}
