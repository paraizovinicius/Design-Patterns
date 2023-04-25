namespace Composite{
    interface Component{
        public void Operation();
        public void Add(Component component);
        public void Remove(Component component);
    }
}