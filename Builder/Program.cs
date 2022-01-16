using Builder;

VacationBuilder dreamVacationBuilder= new DreamVacation();
dreamVacationBuilder.ConstructVacation();
Vacation dreamVacation= dreamVacationBuilder.GetVacation();
Console.WriteLine(dreamVacation.Fligth+" "+dreamVacation.Hotel+" "+dreamVacation.Tranportation);
VacationBuilder lowCostVacationBuilder = new LowCostVacation();
lowCostVacationBuilder.ConstructVacation();
Vacation lowCostVacation = lowCostVacationBuilder.GetVacation();
Console.WriteLine(lowCostVacation.Fligth + " " + lowCostVacation.Hotel + " " + lowCostVacation.Tranportation);
Console.ReadLine(); 
