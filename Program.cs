using PatronDecorator.Component;
using PatronDecorator.ConcreteComponent;
using PatronDecorator.ConcreteDecorators;

ISteve steve = new Steve();
steve = new CascoDecorator(steve);
steve = new PecheraDecorator(steve);
steve = new PecheraDecorator(steve);
steve = new BotasDecorator(steve);

int danorecibido = steve.RecibirDano(11);
Console.WriteLine("Vida restante: " + danorecibido);