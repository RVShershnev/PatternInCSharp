using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// Originator class
    /// </summary>
    /* WikiPedia notes( for your reference):
    Make an object (originator) itself responsible for:
    1.Saving its internal state to a(memento) object and
    2.Restoring to a previous state from a(memento) object.
    Only the originator that created a memento is allowed to access it.*/
    class Originator
    {
        private string state;
        Memento myMemento;
        //public Originator()
        //{
        // //this.State = "Initial state";
        //}
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("Current State : {0}", state);
            }
        }
        // Originator will supply the memento in respond to caretaker's
        //request
        public Memento GetTheMemento()
        {
            //Creating a memento with the current state
            myMemento = new Memento();
            myMemento.State = state;
            return myMemento;
        }
        // Back to old state (Restore)
        public void RevertToState(Memento previousMemento)
        {
            Console.WriteLine("Restoring to previous state...");
            this.state = previousMemento.State;
            Console.WriteLine("Current State : {0}", state);
        }
    }
}
