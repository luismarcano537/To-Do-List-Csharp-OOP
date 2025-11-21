using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Models.Entities;
using ToDoList.Models.Enums;

namespace ToDoList.Services
{
    internal class ItemManagement
    {
        private List<WorkItem> _WorkItem;
        private int _id = 1;

        public ItemManagement()
        {
            _WorkItem = new List<WorkItem>();
        }

        public void AddWorkItem(string description)
        {
            _WorkItem.Add(new WorkItem(description, _id));
            _id++;
        }

        public bool MarkCompletedItem(int id)
        {
            var ItemToMarkComplete = _WorkItem.FirstOrDefault(item => item.Id == id);

            if (ItemToMarkComplete != null)
            {
                ItemToMarkComplete.MarkCompleted();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveWorkItem(int id)
        {
            var itemToRemoved = _WorkItem.FirstOrDefault(item => item.Id == id);

            if (itemToRemoved != null)
            {
                _WorkItem.Remove(itemToRemoved);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<WorkItem> AllItems()
        {
            return _WorkItem.ToList();
        }

        public List<WorkItem> PendingItems()
        {
            return _WorkItem.Where(item => item.statusTask == Status.Pending).ToList();
        }

        public List<WorkItem> CompletedItems()
        {
            return _WorkItem.Where(item => item.statusTask == Status.Complete).ToList();
        }
    }
}
