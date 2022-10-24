// See https://aka.ms/new-console-template for more information
using CSprj;
using CSprj.Service;
using CSprj.Service.Validation;

Console.WriteLine("Hello, World!");
IValidator service = new Validator();
//Ticket a=new Ticket("Hai","hung hoa","1213141",new DateTime(2012,11,11),TicketType.Vip,"haihhtnpt24@gmail.com");
Ticket a=new Ticket();
a.Input();
a.Output();
var validationResult = service.Validate(a);

foreach(var error in validationResult.Errors){
    Console.WriteLine(error.Key + ": ");
    error.Value.ToList().ForEach(x => Console.WriteLine(" " + x));
}
//Console.WriteLine($"ten la{a.Name}");