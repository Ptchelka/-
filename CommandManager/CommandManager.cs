using Storage;
using System.Xml.Linq;
namespace CommandManager
{
    public class Manager : ICommandManager
    {
        private ICommand addNewTask;
        private ICommand addNewResponsable;
        private ICommand makeDone;
        private ICommand giveInformation;
        public ITaskCollection collection;
        public Manager(ITaskCollection collection, ICommand giveInformation, ICommand makeDone, ICommand addNewResponsable, ICommand addNewTask)
        {
            this.collection = collection;
            this.giveInformation = giveInformation;
            this.makeDone = makeDone;
            this.addNewResponsable = addNewResponsable;
            this.addNewTask = addNewTask;
        }
        public void AddNewTask(string name, string deskription)
        {
            addNewTask.Do(name, deskription);
        }
        public void AddNewResponsable(string name, string responsable)
        {
            addNewResponsable.Do(name, responsable);
        }
        public void MakeDone(string name)
        {
            makeDone.Do(name, name);
        }
        public void GiveInformation(string name)
        {
            giveInformation.Do(name, name);
        }
        public void ToFile()
        {
            collection.ToFile();
        }
    }
}
