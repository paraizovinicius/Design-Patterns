namespace Decorator
{
    public abstract class Decorator : Component //Abstract Decorator
    {
        protected Component componente;

        public Decorator(Component componente) //Construtor --> caso não tenha o construtor, a função abaixo vai ter o component retornando NULL
        {
            this.componente = componente;
        }

        public virtual string Execute() //Adicionado o tipo de retorno "string"
        {
            return componente.Execute();
        }
    }
}
