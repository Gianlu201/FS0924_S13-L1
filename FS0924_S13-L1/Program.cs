using FS0924_S13_L1;

var athlete1 = new Athlete();
athlete1.FirstName = "Simone";
athlete1.LastName = "Giannelli";
athlete1.Age = 20;
athlete1.Sport = "volleyball";
athlete1.CompetitionsWinned = 3;

Console.WriteLine(athlete1.Presentation());
Console.WriteLine();

var employee1 = new Employee();
employee1._firstName = "Pippo";
employee1._lastName = "Pluto";
employee1._age = 30;
employee1._job = "Full-stack developer";
employee1._company = "Microsoft";

Console.WriteLine(employee1.SayHello());
Console.WriteLine();

var dog1 = new Animal("Fido", "dog", 5, 4);
Console.WriteLine(dog1.ShowAnimalInfo());
Console.WriteLine();

var car1 = new Vehicle("Ferrari Purosangue", "Ferrari", "FA123GX", 4);
Console.WriteLine(car1.VeichleInfo());