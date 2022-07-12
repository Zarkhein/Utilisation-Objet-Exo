// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

cercle c1 = new cercle(6.25);
Console.WriteLine(c1.getArea());
Console.WriteLine(c1.GetPerimeter());
Console.WriteLine();
Person1 p = new Person1();
p.SayHello();
Console.WriteLine();
Student student = new Student();
Teacher teacher = new Teacher();
student.setAge(15);
student.SayHello();
student.GoToClasses();
student.DisplayAge();
teacher.SayHello();
teacher.Explain();
Console.WriteLine();
Complex cmx = new Complex(4, 6);
Complex cmx2 = new Complex(-2, 3);

Console.WriteLine(cmx.ToString());
Console.WriteLine(cmx.getMagnitude());
cmx.Sum(cmx2);
Console.WriteLine("Voici le resultat: " + cmx.ToString());
Console.WriteLine();

Apartement ap = new Apartement();
Person gs = new Person();
gs.Nom = "Albert";
ap.SetSurface(15);
ap.door.SetColor("red");
gs.House = ap;
gs.Display();

string[] tbl = new string[5];

tbl[0] = gs.Nom;
gs.Nom = "Kenneth";
tbl[1] = gs.Nom;

Console.WriteLine(tbl[0]);
Console.WriteLine(tbl[1]);