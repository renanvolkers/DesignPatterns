namespace Builder.Domain
{
    public class ConcreteBuilder2 : Builder
    {
        public void BuildStepA()
        {
            throw new NotImplementedException("BuildStep A condition");
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
