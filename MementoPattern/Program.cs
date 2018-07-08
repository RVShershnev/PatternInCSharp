using System;
using System.Collections.Generic;

namespace MementoPattern
{
    /// <summary>
    /// The 'Caretaker' class.
    /// WikiPedia notes( for your reference):
    /// A client (caretaker) can request a memento from the originator
    ///to save the internal state of the originator) and
    ///pass a memento back to the originator (to restore to a previous state)
    ///This enables to save and restore the internal state of an originator
    ///without violating its encapsulation
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("***Memento Pattern QAs***");
            Console.WriteLine("***Demonstration-Caretaker is using multiple restore points * **\n");
            //Originator is initialized with a state
            Originator originatorObject = new Originator();
            Memento mementoObject;
            IList<Memento> savedStates = new List<Memento>();
            Console.WriteLine("A new set of verification");
            //State-1
            originatorObject.State = "State-1";
            savedStates.Add(originatorObject.GetTheMemento());
            //State-2
            originatorObject.State = "State-2";
            savedStates.Add(originatorObject.GetTheMemento());
            //State-3
            originatorObject.State = "State-3";
            savedStates.Add(originatorObject.GetTheMemento());
            //State-4 which is not saved
            originatorObject.State = "State-4";
            //Available restore points
            Console.WriteLine("Currently available restore points are :");
            foreach (Memento m in savedStates)
            {
                Console.WriteLine(m.State);
            }
            //Roll back starts...
            Console.WriteLine("Started restoring process...");
            for (int i = savedStates.Count; i > 0; i--)
            {
                mementoObject = originatorObject.GetTheMemento();
                mementoObject.State = savedStates[i - 1].State;
                originatorObject.RevertToState(mementoObject);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
