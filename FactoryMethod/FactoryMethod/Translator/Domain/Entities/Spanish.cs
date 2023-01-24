using FactoryMethod.Translator.Domain.Interface;

namespace FactoryMethod.Translator.Domain.Entities
{
    public class Spanish : ILanguage
    {
        public int Id { get; set; }
        public PossessiveAdjective? PossessiveAdjective { get; set; }
        public PromonounsObject? PromonounsObject { get; set; }


    }
}
