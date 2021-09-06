using System;
public class UserInput {
    static public int GetYearFromUser() {
        int year = 0; 
            int.TryParse(Console.ReadLine(), out year);
            if (year == 0) {
                throw new Exception("Please write the year in numbers only");
            }
            return year; 
        
       
    }
}