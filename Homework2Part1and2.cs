using System;

// define the class
class HelloWorld {

    // define the main method
    static void Main(){
        // ask the user to enter a letter grade
        Console.WriteLine("Please input a letter grade:");
    
        // take input from the user
        char grade=Console.ReadLine()[0];
        // use if-else if -else conditons 
    
        // if grade == A then 
        if(grade=='A')
        {
            // print GPA point 4
            Console.WriteLine("GPA point: 4");
        }
        // if grade == B
        else if(grade=='B')
        {
            // then print GPA point 3
            Console.WriteLine("GPA point: 3");;
        }
        // if grade == C
        else if(grade=='C')
        {
            // then print GPA point 2
            Console.WriteLine("GPA point: 2");
        }
        // if grade == D
        else if(grade=='D') 
        {
            // then print GPA point 1
            Console. WriteLine("GPA point: 1");
        }
        // if grade == F
        else if(grade=='F') 
        {
            // then print GPA point 0
            Console.WriteLine("GPA point: 0");
        }
        // if user enters anything else other than a,b,c,d,f
        else
        {
            // then print Wrong letter grade
            Console.WriteLine("Wrong Letter Grade!");
        }

  static void Main() {
      //get three inputs from the user
    Console.WriteLine("Please input the first num:");
    int a=Convert.ToInt16(Console.ReadLine()); 
    Console.WriteLine("Please input the second num:");
    int b=Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Please input the third num:");
    int c=Convert.ToInt16(Console.ReadLine());
    //declare a variable smallest
    int smallest=0;
    //check if a is the smallest
    if(a<b) {
        if(a<c) {
            smallest=a;
        }
    }
    //check if b is the smallest
    if(b<a) {
        if(b<c) {
            smallest=b;
        }
    }
    //check if c is the smallest
    if(c<a) {
        if(c<b) {
            smallest=c;
        }
    }
    //print the smallest
    Console.WriteLine("The smallest value is: {0}",smallest);
  }
}
// end of the class