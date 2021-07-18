namespace PastaStore
{
    public class SimplePastaFactory
    {
        public static Pasta CreatePasta(Enums.PastaType pastaType)
        {
            switch (pastaType)
            {
                case Enums.PastaType.Bolognese:
                    return new Bolognese();

                case Enums.PastaType.FettuccineAlfredo:
                    return new FettuccineAlfredo();

                case Enums.PastaType.SeafoodPasta:
                    return new SeafoodPasta();

                case Enums.PastaType.SpinachRavioli:
                    return new SpinachRavioli();

                case Enums.PastaType.VeggiePasta:
                    return new VeggiePasta();

                default:
                    return null;
            }
        }
    }
}
