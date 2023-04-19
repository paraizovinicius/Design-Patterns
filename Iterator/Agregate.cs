namespace Iterator{
    public interface Agregate<T>{
        Iterator<T> CreateIterator();
        int Count();
        void Append(T Item);
        void Remove(T Item);
    }
}

