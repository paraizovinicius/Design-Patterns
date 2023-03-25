using System;
using System.Collections.Generic;
namespace Observer{
    // Classe sujeito observado
    class Subject
    {
        private List<Observador> observers = new List<Observador>(); // Instantiating the list of registered observers
        private int value;

        public void Attach(Observador observer) // Adding an observer to the list
        {
            observers.Add(observer);
        }

        public void Detach(Observador observer) // Removing an observer from the list
        {
            observers.Remove(observer);
        }

        public void SetValue(int value) // Altering the value of Subject class and notifying the observers
        {
            this.value = value;
            Notify(); // Call the method to notify observers
        }

        private void Notify() // Iterate every observer in the list and call the method Update for each one
        {
            foreach (Observador observer in observers)
            {
                observer.Update(value);
            }
        }
    }
}
