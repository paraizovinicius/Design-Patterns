namespace Iterator
{
    public class ListIterator<T> : Iterator<T>
    {

        private List<T> _lista;
        private int index;

        public ListIterator(List<T> lista)
        {
            _lista = lista;
            index = 0;
        }

        public T First()
        {
            return _lista[0];
        }

        public T Next()
        {
            index++;
            if (index < _lista.Count)
            {
                return _lista[index];
            }
            else
            {
                throw new Exception("Index is out of range!");
            }
        }

        public bool IsDone()
        {
            return index >= _lista.Count;
        }

        public T CurrentItem()
        {
            return _lista[index];
        }
    }
}