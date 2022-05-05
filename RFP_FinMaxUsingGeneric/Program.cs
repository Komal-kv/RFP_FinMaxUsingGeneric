// See https://aka.ms/new-console-template for more information


using RFP_FindMaxUsingGeneric;

Console.WriteLine("Find The Maximum Program");

Console.WriteLine("--------Maximum integer value-----------");
int output = MaxCheck.MaximumIntegerNumber(70, 100, 29);
Console.WriteLine(output);
Console.WriteLine();
Console.WriteLine("--------Maximum float value-------------");
double doubleoutput = MaxCheck.MaximumFloatNumber(22.11, 7.01, 29.02);
Console.WriteLine(doubleoutput);
Console.WriteLine();
Console.WriteLine("--------Maximum String value------------");
string stringoutput = MaxCheck.MaximumString("Komal", "Payal", "Sneha");
Console.WriteLine(stringoutput);
Console.WriteLine();


int[] intArray = { 2099, 1996, 1500, 6400 };
GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
generic.PrintMaxValue();
double[] doubleArray = { 78.90, 7.01, 23.09, 29.02 };
GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
genericDouble.PrintMaxValue();
string[] stringArray = { "Anjali", "Aakib", "Akash", "Ankita" };
GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
genericString.PrintMaxValue();