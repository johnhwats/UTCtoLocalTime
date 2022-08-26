int year = DateTime.UtcNow.Year;
Console.WriteLine("Convert UTC to your local time");
Console.WriteLine("Enter DateTime in UTC " +
    "(The current year is {0})", year);
Console.Write("Month(MM): ");
var month = Console.ReadLine();
Console.Write("Day(dd): ");
var day = Console.ReadLine();
Console.Write("Hour(HH from 0 to 24): ");
var hour = Console.ReadLine();
Console.Write("Minute(mm): ");
var minute = Console.ReadLine();

if (month == null || day == null || hour == null || minute == null)
{
    return;
}

DateTime input = new DateTime(year,
    int.Parse(month), int.Parse(day), int.Parse(hour),
    int.Parse(minute), 0, DateTimeKind.Utc);
Console.WriteLine("UTC input: {0}", input.ToString("F"));

input = TimeZoneInfo.ConvertTimeFromUtc(input, TimeZoneInfo.Local);

//maybe we consider using this format, ddd yy-MM-dd HH:mm
Console.WriteLine("is {0} in local time " +
    "{1}", input.ToString("F"), TimeZoneInfo.Local.DisplayName);

Console.WriteLine("Press enter to exit.");
Console.ReadLine();