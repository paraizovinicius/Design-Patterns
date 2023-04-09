namespace Interpreter{
    public class NonTerminalExpression : AbstractExpression{

        private AbstractExpression _expression;
        private AbstractExpression _term;

        public NonTerminalExpression(AbstractExpression expression, AbstractExpression term){
            _expression = expression;
            _term = term;
        }

        public override int Interprete(){
            return _expression.Interprete() + _term.Interprete();
        }


    }
}