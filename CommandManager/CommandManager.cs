﻿using Storage;
using System.Xml.Linq;
namespace CommandManager
{
    public class Manager : ICommandManager
    {
        private ICommand addNewTask;
        private ICommand addNewResponsable;
        private ICommand makeDone;
        private ICommand giveInformation;
        public ITaskCollection collection { get;  }
        public Manager(ITaskCollection collection, ICommand addNewTask, ICommand addNewResponsable, ICommand makeDone, ICommand giveInformation)
        {
            this.collection = collection;
            this.giveInformation = giveInformation;
            this.makeDone = makeDone;
            this.addNewResponsable = addNewResponsable;
            this.addNewTask = addNewTask;
        }
        public string AddNewTask(string name, string deskription)
        {
            return addNewTask.Do(name, deskription);
        }
        public string AddNewResponsable(string name, string responsable)
        {
            return addNewResponsable.Do(name, responsable);
        }
        public string MakeDone(string name)
        {
            return makeDone.Do(name, name);
        }
        public string GiveInformation(string name)
        {
            return giveInformation.Do(name, name);
        }
        public int TaskCount()
        {
            return collection.TaskCount();
        }
        public async System.Threading.Tasks.Task ToFile()
        {
            collection.ToFile();
        }
        public async System.Threading.Tasks.Task FromFile()
        {
            collection.FromFile();
        }
    }
}
