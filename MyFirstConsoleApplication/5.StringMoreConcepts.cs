using System;
 class StringMoreConcepts
    {
    static void Main()
    {

        string myProjectPath = "D:\\Csharp_Nov\\MyFirstConsoleApp";
        //myProjectPath.Length
        Console.WriteLine(myProjectPath.Length); //31


        string name1 = "john";   //4
        int lengt = name1.Length;             //4
        Console.WriteLine(lengt); //4

        string name2 = "john";
        string uName2 = name2.ToUpper(); // "JOHN" 
        Console.WriteLine(uName2);

        string name3 = "JohN";
        string uName3 = name3.ToLower(); // "john"  
        Console.WriteLine(uName3);



    }
}

