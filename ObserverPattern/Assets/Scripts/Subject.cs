using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Subject
{
    List<Observer> observers = new List<Observer>();

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.OnNotify();
        }
    }

    public void AddObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(Observer observer)
    {
        observers.Remove(observer);
    }
}
