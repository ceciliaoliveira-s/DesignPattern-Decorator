using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{
    //Concrete Decorator
    public class BaconDecorator : HamburguerDecorator
    {
        public BaconDecorator(IHamburguer hamburguer)
            : base(hamburguer)
        {
        }

        public override string BuscarTipoHamburguer()
        {
            string hamburguer = base.BuscarTipoHamburguer();
            hamburguer += "\r\n X-Bacon: Acrescentando Bacon ao Hambúrguer Simples";
            return hamburguer;
        }
    }
}