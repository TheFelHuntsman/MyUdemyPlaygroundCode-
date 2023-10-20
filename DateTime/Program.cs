/* Creating a new DateTime Value
 * 
 * DateTime.Now - current system date + time 
 * DateTime.Today - Current system date + midnight 
 * DateTime.UTCNow - Current System Date + UTC Time (for time zone neutral) 
 * 
 * new DateTime(Year, Month, Day) 
 * new DateTine( Year, Month, Day, Hour, Minute, Second)
 */

DateTime d1 = DateTime.Now;
DateTime d2 = new DateTime(2023 , 8 , 11);
DateTime d3 = new DateTime(2023 , 8 , 11 , 15 , 15 , 0 );

/* Parsing
 * 
 * DateTime.Parse() and DateTime.TryParse()
 * Any valid culture format works. e.g:
 * 11/8/2023
 * 11/8/2023 15:45:30
 * Fri Aug 11, 2023
 */

DateTime d4 = DateTime.Parse("11/8/2023 15:45:30");
Console.WriteLine(d4);

/*
 * TimeSpan Type
 * Can add or subtract values from dates and is used to calculated differences
 * new TimeSpan(Days, Hours, Minutes Seconds) 
 * new TimeSpan(Hours, Minutes, Seconds) 
 * 
 * Negative values can go backwards in time
 */

TimeSpan ts = d1.Subtract( d4 ); // how long since D3 date time 
Console.WriteLine($"{ts.Days}d,{ts.Hours}h,{ts.Minutes}m,{ts.Seconds}s");

ts = new TimeSpan( 5 , 12 , 13 ,0 ,0 ); // 5d , 12h, 13m 
d4 = d1.Add(ts); // Add to date

Console.WriteLine(d4);

// We can compare dates as well since it compares the "ticks"
Console.WriteLine(d4 > d1);

/* Date Parts
 * 
 * We can get specific parts of date using property values 
 * 
 */

Console.WriteLine($"{d1.Year}/{d1.Month}/{d1.Day}/{d1.Hour}/{d1.Minute}/{d1.Second}/{d1.Millisecond}");

/* Adding date values
 * 
 * AddYears
 * AddMonths
 * AddDays
 * etc..
 */

d1.ad