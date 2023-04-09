namespace Interpreter{
    public class TerminalExpression : AbstractExpression{

        private int _number;

        public TerminalExpression(int numero){
            _number = numero;
        }


        public override int Interprete(){
            return _number;
        }

    }
}