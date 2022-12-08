//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
;
    //string number()
    string DetPolyndrom(int n) 
     {
        string result = "не полиндром";
        if((n / 10000 == n % 10) && ((n / 1000) % 10 == (n / 10) % 10)) 
            result = "полиндром";
        return result;
     }
     
    
    int EnterData(string text)
    {
        Console.WriteLine(text);
        int number = int.Parse(Console.ReadLine());
        return number;
    } 
     
       
        int n = EnterData("Введите число ");
        string number = DetPolyndrom(n);
        Console.WriteLine("Введенное число " + number);
