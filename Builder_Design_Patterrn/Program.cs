using System;

// Product
class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public string Topping { get; set; }

    public void Display()
    {
        Console.WriteLine("Pizza with {0} dough, {1} sauce, and {2} topping.", Dough, Sauce, Topping);
    }
}

// Builder
//This is an interface which is used to define all the steps to create a product
interface IPizzaBuilder
{
    void BuildDough();
    void BuildSauce();
    void BuildTopping();
    Pizza GetPizza();
}

// Concrete Builder
//This is a class which implements the Builder interface to create a complex product.
class MargheritaPizzaBuilder : IPizzaBuilder
{
    private Pizza pizza;

    public MargheritaPizzaBuilder()
    {
        pizza = new Pizza();
    }

    public void BuildDough()
    {
        pizza.Dough = "Thin crust dough";
    }

    public void BuildSauce()
    {
        pizza.Sauce = "Tomato sauce";
    }

    public void BuildTopping()
    {
        pizza.Topping = "Mozzarella cheese";
    }

    public Pizza GetPizza()
    {
        return pizza;
    }
}

// Director
//This is a class which is used to construct an object using the Builder interface.
class PizzaDirector
{
    public Pizza BuildPizza(IPizzaBuilder builder)
    {
        builder.BuildDough();
        builder.BuildSauce();
        builder.BuildTopping();
        return builder.GetPizza();
    }
}

class Program
{
    static void Main()
    {
        // Create the director and builder
        PizzaDirector director = new PizzaDirector();
        IPizzaBuilder builder = new MargheritaPizzaBuilder();

        // Build the pizza
        Pizza pizza = director.BuildPizza(builder);

        // Display the pizza
        pizza.Display();
    }
}
