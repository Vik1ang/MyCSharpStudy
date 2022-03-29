namespace MyUtility.TimeHelper;

public class TimeHelper
{
    /// <summary>
    /// 时间戳转为C#格式时间
    /// </summary>
    /// <param name="timeStamp"></param>
    /// <returns></returns>
    public static DateTime GetTimeByTimeStamp(string timeStamp)
    {
        DateTime dtStart = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(new DateTime(1970, 1, 1), TimeZoneInfo.Local.Id);
        //Console.WriteLine(TimeZoneInfo.Local.Id);
        //Console.WriteLine(dtStart.ToString());
         //= TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1), TimeZoneInfo.Local);
        long lTime = long.Parse(timeStamp + "0000000");
        TimeSpan toNow = new TimeSpan(lTime);
        return dtStart.Add(toNow);
    }

    public static string DataTimeToTimeStamp(DateTime dt)
    {
        DateTime dtStart = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(new DateTime(1970,1,1),TimeZoneInfo.Local.Id);
        return Convert.ToString((int) (dt - dtStart).TotalSeconds);
    }
}