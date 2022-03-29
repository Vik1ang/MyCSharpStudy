using MyUtility.TimeHelper;
using MyUtility.Tools;

var userIp = Tools.GetIpAddress();
Console.WriteLine(userIp);

DateTime dt = TimeHelper.GetTimeByTimeStamp(TimeHelper.DataTimeToTimeStamp(DateTime.Now));
Console.WriteLine(dt.ToString());

Console.WriteLine(TimeHelper.GetMonthLastDate(2022, 3));

Console.WriteLine(TimeHelper.GetFormatDate(DateTime.Now));
Console.WriteLine(TimeHelper.GetFormatTime(DateTime.Now));
Console.WriteLine(TimeHelper.SecondToMinute(121));