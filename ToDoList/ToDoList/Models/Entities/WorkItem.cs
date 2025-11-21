using System;
using System.Collections.Generic;
using System.Data;
using ToDoList.Models.Enums;
using ToDoList.Services;

namespace ToDoList.Models.Entities
{
    internal class WorkItem
    {
        public int Id { get; private set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; private set; }
        public Status statusTask { get; private set; }


        public WorkItem(string description, int id)
        {
            Id = id;
            Description = description;
            CreationTime = DateTime.Now;
            statusTask = Status.Pending;
        }

        public void MarkCompleted()
        {
            statusTask = Status.Complete;
        }

        public override string ToString()
        {
            return "ID: " + Id
                +" - Task: " + Description
                + " - Creation Time: " + CreationTime
                + " - Status: " + statusTask;
        }
    }
}
