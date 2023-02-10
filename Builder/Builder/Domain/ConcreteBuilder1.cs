namespace Builder.Domain
{
    public class ConcreteBuilder1 : Builder
    {
       public Product1? product1 { get; set; }

        public ConcreteBuilder1()
        {
            this.Reset();
        }
        public void BuildStepA()
        {
            throw new NotImplementedException("Stop Play");
        }

        public void BuildStepB()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            this.product1 = new Product1();
        }
    }
}
