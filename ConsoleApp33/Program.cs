using Autofac;
using ConsoleApp33;
//beverage
var builder = new ContainerBuilder();
builder.RegisterType<Tea>().As<Beverage>();
builder.RegisterType<Coffee>().As<Beverage>();
builder.RegisterType<Juice>().As<Beverage>();
var container = builder.Build();

var tea = container.Resolve<Beverage>(new TypedParameter(typeof(string), "Black Tea"), new TypedParameter(typeof(string), "A robust black tea with a full-bodied flavor."), new TypedParameter(typeof(decimal), 2.50m));
var coffee = container.Resolve<Beverage>(new TypedParameter(typeof(string), "Espresso"), new TypedParameter(typeof(string), "A small, concentrated coffee made with finely ground beans."), new TypedParameter(typeof(decimal), 3.00m));
var juice = container.Resolve<Beverage>(new TypedParameter(typeof(string), "Orange Juice"), new TypedParameter(typeof(string), "Freshly squeezed orange juice."), new TypedParameter(typeof(decimal), 4.00m));

Console.WriteLine(tea.GetName() + ": " + tea.GetDescription() + " - $" + tea.GetPrice());
Console.WriteLine(coffee.GetName() + ": " + coffee.GetDescription() + " - $" + coffee.GetPrice());
Console.WriteLine(juice.GetName() + ": " + juice.GetDescription() + " - $" + juice.GetPrice());

using (StreamWriter writer = new StreamWriter("beverages.txt"))
{
    writer.WriteLine(tea.GetName() + ": " + tea.GetDescription() + " - $" + tea.GetPrice());
    writer.WriteLine(coffee.GetName() + ": " + coffee.GetDescription() + " - $" + coffee.GetPrice());
    writer.WriteLine(juice.GetName() + ": " + juice.GetDescription() + " - $" + juice.GetPrice());
}

//song
builder = new ContainerBuilder();
builder.RegisterType<Song>();
container = builder.Build();

var song = container.Resolve<Song>(new TypedParameter(typeof(string), "Bohemian Rhapsody"), new TypedParameter(typeof(string), "Queen"), new TypedParameter(typeof(int), 1975), new TypedParameter(typeof(string), "Is this the real life?\nIs this just fantasy?\nCaught in a landslide,\nNo escape from reality\n"));
Console.WriteLine(song.GetInformation());

using (StreamWriter writer = new StreamWriter("song.txt"))
{
    writer.WriteLine(song.GetInformation());
}

Console.WriteLine(song.GetMorseCode());

using (StreamWriter writer = new StreamWriter("song-morse-code.txt"))
{
    writer.WriteLine(song.GetMorseCode());
}

//ChessPiece
builder = new ContainerBuilder();
builder.RegisterType<Pawn>();
builder.RegisterType<Knight>();
builder.RegisterType<Bishop>();
builder.RegisterType<Rook>();
builder.RegisterType<Queen>();
builder.RegisterType<King>();
container = builder.Build();

var pawn = container.Resolve<Pawn>();
Console.WriteLine(pawn.GetInformation());

using (StreamWriter writer = new StreamWriter("pawn.txt"))
{
    writer.WriteLine(pawn.GetInformation());
}

var knight = container.Resolve<Knight>();
Console.WriteLine(knight.GetInformation());

using (StreamWriter writer = new StreamWriter("knight.txt"))
{
    writer.WriteLine(knight.GetInformation());
}
//Fruit
  builder = new ContainerBuilder();
builder.RegisterType<Apple>();
builder.RegisterType<Banana>();
builder.RegisterType<Orange>();
  container = builder.Build();

var apple = container.Resolve<Apple>();
Console.WriteLine(apple.GetInformation());

using (StreamWriter writer = new StreamWriter("apple.txt"))
{
    writer.WriteLine(apple.GetInformation());
}

var banana = container.Resolve<Banana>();
Console.WriteLine(banana.GetInformation());

using (StreamWriter writer = new StreamWriter("banana.txt"))
{
    writer.WriteLine(banana.GetInformation());
}

var orange = container.Resolve<Orange>();
Console.WriteLine(orange.GetInformation());

using (StreamWriter writer = new StreamWriter("orange.txt"))
{
    writer.WriteLine(orange.GetInformation());
}