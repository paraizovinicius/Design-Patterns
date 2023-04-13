using System;
using System.Collections.Generic;
namespace Iterator{
    public class ListAgregate<T> : Agregate<T>{
        
        private List<T> lista;

        public ListAgregate() {
            lista = new List<T>();
        }

        public Iterator<T> CreateIterator() {
            return new ListIterator<T>(lista);
        }

        public int Count() {
            return lista.Count;
        }

        public void Append(T item) {
            lista.Add(item);
        }

        public void Remove(T item) {
            lista.Remove(item);
        }
    }
}