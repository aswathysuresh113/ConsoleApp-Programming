//empty datetime
DateTime date = new DateTime();
// create datetime from datetime
DateTime dateofbirth = new DateTime(1993, 1, 13);
Console.WriteLine($"date of birth is {dateofbirth}");
// parsed date
DateTime parseddate = DateTime.Parse("1993, 1, 13");
Console.WriteLine($"parsed date is {parseddate}");
//create Datetime from currentTimestamp
DateTime now = DateTime.Now;
Console.WriteLine($"current  datetime is {now}");
//date to ticks
Console.WriteLine($"Ticks for now is {now.Ticks}");
// add hours to dateTime
Console.WriteLine($"2 hours from now is {now.AddHours(2)}");
// date only
DateOnly dob = DateOnly.FromDateTime(dateofbirth);
//time only
TimeOnly tob = TimeOnly.FromDateTime(dateofbirth);
