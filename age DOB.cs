using System.IO;
using System;
					
public class Program
{
	public static void Main()
	{
		DateTime dob=new DateTime(1999,6,07);
		DateTime dt=DateTime.Now;
		int Day= dt.Day-dob.Day;
		int Month= dt.Month-dob.Month;
		int Year= dt.Year-dob.Year;
		Console.WriteLine(String.Format("Age: " +Year+ " Year(s) " +Month+" Month(s) " +Day+" Day(s) "));
	}
}