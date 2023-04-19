using System.Globalization;
namespace Mediator{
    class Colleague{

        protected IMediator _mediator;

        public Colleague(IMediator mediator = null){
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator){
            this._mediator = mediator;
        }
    }
}