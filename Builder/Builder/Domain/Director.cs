﻿namespace Builder.Domain
{
    public class Director
    {
        public void constructProduct1(Builder builder)
        {
            builder.Reset();
            builder.BuildStepA();
            builder.BuildStepB();
        }

    }
}