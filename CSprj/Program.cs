// See https://aka.ms/new-console-template for more information
using CSprj;
using CSprj.Service;
using CSprj.Service.Validation;

Console.WriteLine("Hello, World!");
IValidator service = new Validator();
var validationResult = service.Validate(new Ticket());
foreach(var error in validationResult.Errors){
    Console.WriteLine(error.Key + ": ");
    error.Value.ToList().ForEach(x => Console.WriteLine(" " + x));
}