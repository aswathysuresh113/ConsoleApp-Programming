
using System.Collections.Generic;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;


//var calculations = new Calculations();

var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
{
    HasHeaderRecord = false,
};

using var streamReader = File.OpenText(@"D:\\Downloads\\test.csv");
using var csvReader = new CsvReader(streamReader, csvConfig);
var statement = csvReader.GetRecords<Statement>();
double total = 0;
double monthlyBalance = 0;


Console.Write("Enter the month : ");
string input =(Console.ReadLine()).ToLower();

foreach (var record in statement)
{
    total += record.amount;
    Console.WriteLine(record);
    if (input  == (record.month.ToString("MMMM")).ToLower())
    {     
                monthlyBalance += record.amount;         
              
            }

}
Console.WriteLine(monthlyBalance);
Console.WriteLine(total);


