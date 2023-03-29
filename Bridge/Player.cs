using System;
namespace Bridge{
    
    class Player{
        // Defines the implementation class for the players
        private string name;

        public Player(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }

}

