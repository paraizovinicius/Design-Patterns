namespace Prototype
{
    class House
    {
        public int AddressNumber;
        public string StreetAddress;
        public Register _register;

        public House() { }

        public House(int addressNumber, string streetAddress)
        {
            AddressNumber = addressNumber;
            StreetAddress = streetAddress;
        }

        public House Copy()
        {
            House clone = (House)this.MemberwiseClone();
            clone._register = new Register(_register._register);
            clone.StreetAddress = String.Copy(StreetAddress);
            return clone;
        }

        public Register Register
        {
            get { return _register; }
            set { _register = value; }
        }
    }
}