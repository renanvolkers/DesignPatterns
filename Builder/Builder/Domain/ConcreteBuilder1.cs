namespace Builder.Domain
{
    public class ConcreteBuilder1 : Builder
    {
        public void BuildStepA()
        {
            throw new NotImplementedException("Stop Play");
        }

        public void BuildStepB()
        {
            throw new NotImplementedException();
        }

        public int Reset()
        {
            throw new NotImplementedException();
        }
    }
}
