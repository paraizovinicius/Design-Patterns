namespace State{
    public class Context
    {
        private State state;

        public Context(State state) // Constructor of object state 
        {
            this.state = state;
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public void Request()
        {
            //Behaviour to initial state
            state.Handle(this);
        }
    }

}