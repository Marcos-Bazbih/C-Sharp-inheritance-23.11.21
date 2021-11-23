using ConsoleProject_21_11_21;

//Car car1 = new Car("BMW", 150, "red");
//Car car2 = new Car("Mazda", 75, "black");
//Car car3 = new Car("KIA", 200, "white");
//Car car4 = new Car("Honda", 50, "gray");
//Car car5 = new Car("Audi", 65, "blue");

//Car[] carsArray = new Car[] { car1, car2, car3, car4, car5 };

//Console.WriteLine("before sorting");
//for (int i = 0; i < carsArray.Length; i++)
//{
//    carsArray[i].PrintInfo();
//}
//Array.Sort(carsArray);
//Console.WriteLine("after sorting");
//for (int i = 0; i < carsArray.Length; i++)
//{
//    carsArray[i].PrintInfo();
//}

//Bus bus1 = new Bus();
//Bus bus2 = new Bus();
//Bus bus3 = new Bus();

//bus1.Seats = 20;
//bus1.Company = "Eged";

//bus2.Seats = 35;
//bus2.Company = "Metropolin";

//bus3.Seats = 15;
//bus3.Company = "Afikim";

//Console.WriteLine($"{bus1.Seats} - {bus1.Company}");
//Console.WriteLine($"{bus2.Seats} - {bus2.Company}");
//Console.WriteLine($"{bus3.Seats} - {bus3.Company}");

//Truck[] trucksArray = new Truck[4];

//trucksArray[0] = new Truck("truck1", 1050, "black", "marcos", 4);
//trucksArray[1] = new Truck("truck2", 750, "white", "lior", 8);
//trucksArray[2] = new Truck("truck3", 880, "red", "matan", 16);
//trucksArray[3] = new Truck("truck4", 1500, "blue", "hain", 4);


//Console.WriteLine("before sort");
//for (int i = 0; i < trucksArray.Length; i++)
//{
//    trucksArray[i].PrintInfo();
//}

//Array.Sort(trucksArray);

//Console.WriteLine("after sort");
//for (int i = 0; i < trucksArray.Length; i++)
//{
//    trucksArray[i].PrintInfo();
//}

//Squere squere1 = new Squere(20, 35);
//Rectangle rec1 = new Rectangle(15, 40);
//Ribua ribua1 = new Ribua(7, 12);

//Console.WriteLine(rec1.GetSum());
//Console.WriteLine(squere1.GetSum());
//Console.WriteLine(ribua1.GetSum());

//User user1 = new User();
//user1.name = "marcos";
//user1.birthYear = 1998;
//user1.email = "marcos@email.com";

//User user2 = new User("haim", 1996, "haim@email");
//User user3 = new User("lior", 2000, "lior@email");
//User user4 = new User("matan", 1995, "matan@email");
//User user5 = new User("ermias", 2003, "ermias@email");

//User[] usersArray = new[] { user1, user2, user3, user4, user5 };

//Console.WriteLine("before sort");
//for (int i = 0; i < usersArray.Length; i++)
//{
//    usersArray[i].PrintInfo();
//}

//Array.Sort(usersArray);

//Console.WriteLine("before sort");
//for (int i = 0; i < usersArray.Length; i++)
//{
//    usersArray[i].PrintInfo();
//}

//Manager manager1 = new Manager();
//manager1.Division = "dev";
//manager1.Salary = 50;
//manager1.NumberOfEmployees = 50;

//Console.WriteLine(manager1.Division);
//Console.WriteLine(manager1.Salary);
//Console.WriteLine(manager1.NumberOfEmployees);

Employee employee1 = new Employee("marcos", 1998, "marcos@gmail", "front end", 555);
Employee employee2 = new Employee("haim", 1996, "haim@gmail", "back end", 333);
Employee employee3 = new Employee("lior", 1997, "lior@gmail", "server", 444);
Employee employee4 = new Employee("matan", 1995, "matan@gmail", "ui/ux", 222);

Employee[] employeesArray= new Employee[] { employee1, employee2, employee3, employee4 };

employee1.GetPrintedInfo();

//Console.WriteLine("before sort");
//for (int i = 0; i < employeesArray.Length; i++)
//{
//    employeesArray[i].PrintInfo();
//}

//Array.Sort(employeesArray);

//Console.WriteLine("before sort");
//for (int i = 0; i < employeesArray.Length; i++)
//{
//    employeesArray[i].PrintInfo();
//}