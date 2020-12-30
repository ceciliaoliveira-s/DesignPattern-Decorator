using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{
    //Base Decorator
    public class HamburguerDecorator : IHamburguer
    {
        private readonly IHamburguer _hamburguer;

        public HamburguerDecorator(IHamburguer hamburguer)
        {
            this._hamburguer = hamburguer;
        }

        public virtual string BuscarTipoHamburguer()
        {
            var hamburguer = _hamburguer.BuscarTipoHamburguer();
            return hamburguer;
        }
    }
}
