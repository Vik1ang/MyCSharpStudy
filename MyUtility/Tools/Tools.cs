using System.Net;
using System.Net.Sockets;

namespace MyUtility.Tools;

/// <summary>
/// 公用工具类
/// </summary>
public class Tools
{
    public static string GetIpAddress()
    {
        string ip4 = string.Empty;
        IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in ipHostEntry.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                ip4 = ip.ToString();
                break;
            }
        }

        return ip4;
    }
}