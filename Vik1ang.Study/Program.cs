using MyUtility.TimeHelper;
using MyUtility.Tools;

var userIp = Tools.GetIpAddress();
Console.WriteLine(userIp);

DateTime dt = TimeHelper.GetTimeByTimeStamp("1648545498");
Console.WriteLine(dt.ToString());

string ts = TimeHelper.DataTimeToTimeStamp(new DateTime());
Console.WriteLine(ts);