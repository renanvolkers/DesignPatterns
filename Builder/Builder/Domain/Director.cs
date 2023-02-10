namespace Builder.Domain
{
    public class Director
    {
        public void ConstructProduct1(Builder builder)
        {
            builder.Reset();
            builder.BuildStepA();
            builder.BuildStepB();
        }

    }
}
