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
        DateTime dtStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        return dtStart.AddSeconds(double.Parse(timeStamp)).ToLocalTime();
    }

    /// <summary>
    /// DateTime时间格式转换为Unix时间戳格式
    /// </summary>
    /// <param name="dt"></param>
    /// <returns></returns>
    public static string DataTimeToTimeStamp(DateTime dt)
    {
        DateTime dtStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        return Convert.ToString((TimeZoneInfo.ConvertTimeToUtc(dt) - dtStart).TotalSeconds);
    }

    /// <summary>
    /// 将时间格式化成 年月日 的形式,如果时间为null，返回当前系统时间
    /// </summary>
    /// <param name="dt"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static string GetFormatDate(DateTime dt, char separator = '/')
    {
        if (dt != null && !dt.Equals(DBNull.Value))
        {
            string format = $"yyyy{separator}MM{separator}dd";
            return dt.ToString(format);
        }
        else
        {
            return GetFormatDate(DateTime.Now, separator);
        }
    }

    /// <summary>
    /// 将时间格式化成 时分秒 的形式,如果时间为null，返回当前系统时间
    /// </summary>
    /// <param name="dt"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static string GetFormatTime(DateTime dt, char separator = '/')
    {
        if (dt != null && !dt.Equals(DBNull.Value))
        {
            string format = $"hh{separator}mm{separator}ss";
            return dt.ToString(format);
        }
        else
        {
            return GetFormatDate(DateTime.Now, separator);
        }
    }

    /// <summary>
    /// 把秒转换成分钟
    /// </summary>
    /// <param name="second"></param>
    /// <returns></returns>
    /// TODO: 要改一下
    public static int SecondToMinute(int second)
    {
        decimal mm = second / (decimal)60;
        return Convert.ToInt32(Math.Ceiling(mm));
    }

    /// <summary>
    /// 返回某年某月最后一天
    /// </summary>
    /// <param name="year"></param>
    /// <param name="month"></param>
    /// <returns></returns>
    public static int GetMonthLastDate(int year, int month)
    {
        DateTime lastDay = new DateTime(year, month,
            new System.Globalization.GregorianCalendar().GetDaysInMonth(year, month));
        return lastDay.Day;
    }

    /// <summary>
    /// 获得两个日期的间隔
    /// </summary>
    /// <param name="dt1"></param>
    /// <param name="dt2"></param>
    /// <returns></returns>
    public static TimeSpan DateDiff(DateTime dt1, DateTime dt2)
    {
        TimeSpan ts1 = new TimeSpan(dt1.Ticks);
        TimeSpan ts2 = new TimeSpan(dt2.Ticks);
        return ts1.Subtract(ts2).Duration();
    }

    /// <summary>
    /// 格式化日期时间
    /// </summary>
    /// <param name="dateTime1">日期时间</param>
    /// <param name="dateMode">显示模式</param>
    /// <returns>0-9种模式的日期</returns>
    public static string FormatDate(DateTime dateTime1, string dateMode)
    {
        switch (dateMode)
        {
            case "0":
                return dateTime1.ToString("yyyy-MM-dd");

            case "1":
                return dateTime1.ToString("yyyy-MM-dd HH:mm:ss");

            case "2":
                return dateTime1.ToString("yyyy/MM/dd");

            case "3":
                return dateTime1.ToString("yyyy年MM月dd日");

            case "4":
                return dateTime1.ToString("MM-dd");

            case "5":
                return dateTime1.ToString("MM/dd");

            case "6":
                return dateTime1.ToString("MM月dd日");

            case "7":
                return dateTime1.ToString("yyyy-MM");

            case "8":
                return dateTime1.ToString("yyyy/MM");

            case "9":
                return dateTime1.ToString("yyyy年MM月");

            default:
                return dateTime1.ToString();
        }
    }

    /// <summary>
    /// 得到随机日期
    /// </summary>
    /// <param name="t1"></param>
    /// <param name="t2"></param>
    /// <returns>间隔日期之间的 随机日期</returns>
    public static DateTime GetRandomTime(DateTime t1, DateTime t2)
    {
        Random random = new Random();
        DateTime minTime = new DateTime();
        DateTime maxTime = new DateTime();

        TimeSpan ts = new System.TimeSpan(t1.Ticks - t2.Ticks);

        // 获取两个时间相隔的秒数
        double dTotalSecontds = ts.TotalSeconds;
        int iTotalSecontds = 0;

        if (dTotalSecontds > System.Int32.MaxValue)
        {
            iTotalSecontds = System.Int32.MaxValue;
        }
        else if (dTotalSecontds < System.Int32.MinValue)
        {
            iTotalSecontds = System.Int32.MinValue;
        }
        else
        {
            iTotalSecontds = (int)dTotalSecontds;
        }

        if (iTotalSecontds > 0)
        {
            minTime = t2;
            maxTime = t1;
        }
        else if (iTotalSecontds < 0)
        {
            minTime = t1;
            maxTime = t2;
        }
        else
        {
            return t1;
        }

        int maxValue = iTotalSecontds;

        if (iTotalSecontds <= Int32.MinValue)
            maxValue = Int32.MinValue + 1;

        int i = random.Next(System.Math.Abs(maxValue));

        return minTime.AddSeconds(i);
    }

    /// <summary>
    /// 将String转换为DateTime?类型
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public static DateTime? ParseToDateTime(string date)
    {
        if (string.IsNullOrEmpty(date)) return null;
        if (!DateTime.TryParse(date, out DateTime dt)) return null;
        return dt;
    }

    /// <summary>
    /// 格式化日期 {0:yyyy-MM-dd}
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public static string FormatDate(string date)
    {
        DateTime? dt = ParseToDateTime(date);
        if (dt == null) return string.Empty;
        return $"{dt:yyyy-MM-dd}";
    }

    /// <summary>
    /// 格式化日期 {0:yyyy-MM-dd}
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public static string FormatDate(DateTime? date)
    {
        return date == null ? string.Empty : $"{date:yyyy-MM-dd}";
    }

    /// <summary>
    /// 指定的日期格式格式化日期
    /// </summary>
    /// <param name="dt"></param>
    /// <param name="dateFormat"></param>
    /// <returns></returns>
    public static string FormatDateTime(DateTime dt, string dateFormat)
    {
        string result = null!;
        try
        {
            result = dt.ToString(dateFormat);
        }
        catch
        {
            // ignored
        }

        return result;
    }

    /// <summary>
    /// 获取两个时间差：返回 年
    /// </summary>
    /// <param name="dt1"></param>
    /// <param name="dt2"></param>
    /// <returns></returns>
    public static double GetYearsBetweenTwoDate(DateTime? dt1, DateTime? dt2)
    {
        if (dt1 == null || dt2 == null) return 0;
        int months = GetMonthsBetweenTwoDate(dt1, dt2);

        double years = months / 12d;
        return double.Parse($"{years:N2}");
    }

    /// <summary>
    /// 获取两个时间差：返回 月
    /// </summary>
    /// <param name="dt1"></param>
    /// <param name="dt2"></param>
    /// <returns></returns>
    public static int GetMonthsBetweenTwoDate(DateTime? dt1, DateTime? dt2)
    {
        if (dt1 == null || dt2 == null) return 0;
        int months = ((dt2.Value.Year - dt1.Value.Year) * 12) + (dt2.Value.Month - dt1.Value.Month);
        // 如果天数还没到，月数要减1
        if (dt2.Value.Day < dt1.Value.Day)
        {
            months--;
        }

        return months;
    }

    /// <summary>
    /// 获取两个时间差：返回 天
    /// </summary>
    /// <param name="dt1"></param>
    /// <param name="dt2"></param>
    /// <returns></returns>
    public static int GetDaysBetweenTwoDate(DateTime? dt1, DateTime? dt2)
    {
        if (dt1 == null || dt2 == null) return 0;
        TimeSpan timeSpan = dt2.Value.Subtract(dt1.Value);
        return int.Parse(timeSpan.Days.ToString());
    }

    /// <summary>
    /// 获取季度的开始日期
    /// </summary>
    /// <param name="year"></param>
    /// <param name="quarter"></param>
    /// <returns></returns>
    public static DateTime? GetStartDateOfQuarter(int year, int quarter)
    {
        string strDt = year.ToString() + "-" + ((quarter - 1) * 3 + 1) + "-1";
        return ParseToDateTime(strDt);
    }

    /// <summary>
    /// 获取季度的结束日期
    /// </summary>
    /// <param name="year"></param>
    /// <param name="quarter"></param>
    /// <returns></returns>
    public static DateTime? GetEndDateOfQuarter(int year, int quarter)
    {
        DateTime? dtStart = GetStartDateOfMonth(year, quarter);
        return dtStart?.AddMonths(3).AddDays(-1);
    }

    /// <summary>
    /// 获取日期对应的季度
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public static int GetQuarter(DateTime date)
    {
        if ((date.Month % 3) > 0)
        {
            return (date.Month / 3 + 1);
        }

        return date.Month / 3;
    }

    /// <summary>
    /// 获取月份的开始日期
    /// </summary>
    /// <param name="year"></param>
    /// <param name="month"></param>
    /// <returns></returns>
    public static DateTime? GetStartDateOfMonth(int year, int month)
    {
        string strDt = year.ToString() + "-" + month.ToString() + "-1";
        return ParseToDateTime(strDt);
    }

    /// <summary>
    /// 获取月份的结束日期
    /// </summary>
    /// <param name="year"></param>
    /// <param name="month"></param>
    /// <returns></returns>
    public static DateTime? GetEndDateOfMonth(int year, int month)
    {
        DateTime? startDt = GetStartDateOfMonth(year, month);
        return startDt?.AddMonths(1).AddDays(-1);
    }

    public static int WeekOfMonth(DateTime day, int weekStart)
    {
        //WeekStart
        //1表示 周一至周日 为一周

        //2表示 周日至周六 为一周

        var firstOfMonth = Convert.ToDateTime(day.Date.Year + "-" + day.Date.Month + "-" + 1);

        int i = (int)firstOfMonth.Date.DayOfWeek;
        if (i == 0)
        {
            i = 7;
        }

        return weekStart switch
        {
            1 => (day.Date.Day + i - 2) / 7 + 1,
            2 => (day.Date.Day + i - 1) / 7,
            _ => 0
        };
        //错误返回值0
    }
}