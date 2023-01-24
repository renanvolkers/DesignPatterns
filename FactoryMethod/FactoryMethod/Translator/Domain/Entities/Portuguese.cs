namespace FactoryMethod.Translator.Domain.Entities
{
    public class Portuguese: ILanguage
    {
        public int Id { get; set; }
        public PossessiveAdjective PossessiveAdjective { get; set; }
        public PromonounsObject PromonounsObject { get; set; }


    }
}
