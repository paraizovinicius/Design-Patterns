using System.Globalization;
namespace Adapter{
    class Adapter : Target{

        Adaptee _adaptee = new Adaptee();
        public Adapter(Adaptee adaptee){
            this._adaptee = adaptee;
        }
        public string Request(){
            return $"\n But now it's adapted to the {this._adaptee.SpecificRequest()}";
        }
    }
}