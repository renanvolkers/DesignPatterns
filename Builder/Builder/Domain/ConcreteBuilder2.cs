namespace Builder.Domain
{
    public class ConcreteBuilder2 : Builder
    {
        public Product2? product2 { get; set; } 
        
        public ConcreteBuilder2()
        {
            this.Reset();
        }
        public void BuildStepA()
        {
            throw new NotImplementedException("BuildStep A condition");
        }

        public void BuildStepB()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            this.product2 = new Product2();
        }
    }
}
