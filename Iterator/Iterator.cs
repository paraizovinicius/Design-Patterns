namespace Iterator{
    public interface Iterator<T>{
        T First();
        T Next();
        bool IsDone(); //Is there more?
        T CurrentItem();
    }
}