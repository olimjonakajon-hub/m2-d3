

//  Task1


// for (;;)
// {
//     Console.Write("Enter first number: ");
//     double a = Convert.ToDouble(Console.ReadLine());

//     Console.Write("Enter second number: ");
//     double b = Convert.ToDouble(Console.ReadLine());

//     Console.Write("Enter operation (+, -, *, /): ");
//     string? op = Console.ReadLine();

//     Calculator calculator = new Calculator(a, b);

//     switch (op)
//     {
//         case "+":
//             Console.WriteLine(calculator.sum());
//             break;

//         case "-":
//             Console.WriteLine(calculator.Subtract());
//             break;

//         case "*":
//             Console.WriteLine(calculator.Multiplication());
//             break;

//         case "/":
//             if (b != 0)
//             {
//                 Console.WriteLine(calculator.Division());
//             }
//             else
//             {
//                 Console.WriteLine("Cannot divide by zero");
//             }
//             break;

//         default:
//             Console.WriteLine("ERROR");
//             break;
//     }
// }




// Task2



// User[] users = new User[5];

// users[0] = new User("Ali", "Aliyev", "ali123", "1111");
// users[1] = new User("Olim", "Olimov", "olim123", "2222");
// users[2] = new User("Adulo", "Sharipov", "Abduloo123", "3333");
// users[3] = new User("Said", "Saidov", "said123", "4444");
// users[4] = new User("zafar", "Rahimov", "zafar123", "5555");



// Task 3

// Student student = new Student(1, "olimjon", 21, 3.1);


// student.GetInfo();

//     System.Console.WriteLine(student.IsExcellentStudent());


// Task 4

// Order order1 = new Order(101, "Laptop", 2, 251.0M);
// Order order2 = new Order(50, "ipon", 5, 20.1m);
// Order order3 = new Order(101, "samsung", 3, 201.0M);

// order1.DisplayInfo();
// order2.DisplayInfo();
// order3.DisplayInfo(); 



// Task5


// Book book =new Book("bahoriston;", "abdullo;", 2014);
// book.GetInfo();
// System.Console.WriteLine(book.IsPublishedRecently());



// Task6



// double r = Convert.ToDouble(Console.ReadLine());
 


//         Circle c = new Circle(r);

//         Console.WriteLine("Radius = " + c.GetRadius());
//         Console.WriteLine("Area = " + c.GetArea());
//         Console.WriteLine("Diameter = " + c.GetDiameter());
//         Console.WriteLine("Circumference = " + c.GetCircumference());
  


//   Task 7
//         Date d = new Date(5, 3, 2026);

//         Console.WriteLine(d.ToString());
//         Console.WriteLine(d.GetDay());
//         Console.WriteLine(d.GetMonth());
// Console.WriteLine(d.GetYear());


// Task 8

//  BankAccount ss = new BankAccount(101, 500, "Olim");

//         ss.ShowInfo();

//         ss.Deposit(200);
//         ss.Withdraw(100);

//         ss.ShowInfo();

//         ss.FreezeAccount();
//         ss.Withdraw(50);

//         ss.UnfreezeAccount();
//         ss.Deposit(100);

//         ss.ShowInfo();








