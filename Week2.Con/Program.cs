// See https://aka.ms/new-console-template for more information
using Week2.Con.LSP;
using  Week2.Con.SRP;
using static Week2.Con.OCP.TypeManagement;
using Week2.Con.ISP;
using Week2.Con.DIP;


//Single Responsibility Principle (SRP)
DeleteProduct del = new DeleteProduct();
Console.WriteLine(del.DelProduct());
UpdateProduct upd = new UpdateProduct();
Console.WriteLine(upd.UpdProduct());

Console.WriteLine("--------------");

//Open Closed Principle (OCP)
RoleDecision rd = new RoleDecision();
rd.ProduceVehicle(new Manager());
Console.WriteLine(rd+"\n");
rd.ProduceVehicle(new Chef());
Console.WriteLine(rd+"\n");

Console.WriteLine("--------------");

//Liskov Substitution Principle(LSP) 
Animal animal = new Bird();
animal.Talk();
((IFlying)animal).Flying();

Console.WriteLine("--------------");

//DIP
INameRepository nm = new NameRepository();
nm= new NameRepositoryFromMongo();
NameService ns = new NameService(nm);
Console.WriteLine(String.Join(", ", ns.GetName()));


Console.ReadLine();