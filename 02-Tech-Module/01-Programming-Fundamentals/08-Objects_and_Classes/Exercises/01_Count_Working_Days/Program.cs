﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace _01_Count_Working_Days
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
			DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

			int workingDays = 0;
			bool holiday = false;

			List<DateTime> holidays = new List<DateTime>()
			{
				DateTime.ParseExact("01-01-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
				DateTime.ParseExact("03-03-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
				DateTime.ParseExact("01-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
				DateTime.ParseExact("06-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
				DateTime.ParseExact("24-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
				DateTime.ParseExact("06-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
				DateTime.ParseExact("22-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
				DateTime.ParseExact("01-11-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
				DateTime.ParseExact("24-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
				DateTime.ParseExact("25-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
				DateTime.ParseExact("26-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
			};

			for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
			{
				if (i.DayOfWeek.ToString() == "Saturday" || i.DayOfWeek.ToString() == "Sunday")
				{
					holiday = true;
				}

				for (int j = 0; j < holidays.Count; j++)
				{
					if (i.Month == holidays[j].Month && i.Day == holidays[j].Day)
					{
						holiday = true;
					}
				}

				if (!holiday)
				{
					workingDays++;
				}
				holiday = false;
			}

			Console.WriteLine(workingDays);
		}
	}
}