﻿
namespace Storage
{
    public interface ITaskCollection
    {
        void AddNewTask(string name, string deskription);

        void AddNewResponsable(string name, string responsable);

        void MakeDone(string name);
        void GiveInformarion(string name);
        void ToFile();
        void FromFile();
        int FindTask(string name);

    }
}
