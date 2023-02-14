Public class Application {
Public builder builder {get;set}
Concreteproduct1 product1;
Concreteproduct2 product2;
Director director;
director = new Director(product1);
Var product1 = director.Build();
}
