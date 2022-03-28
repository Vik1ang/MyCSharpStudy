using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MyUtility.StringHelper;

/// <summary>
/// 字符串操作类
/// </summary>
public class StringHelper
{
    /// <summary>
    /// 把字符串按照分隔符转换成List
    /// </summary>
    /// <param name="str">源字符串</param>
    /// <param name="separator">分隔符</param>
    /// <param name="toLower">是否转换为小写</param>
    /// <returns></returns>
    public static List<string> GetStrArray(string str, char separator, bool toLower)
    {
        List<string> list = new List<string>();
        string[] ss = str.Split(separator);
        foreach (string s in ss)
        {
            if (!string.IsNullOrEmpty(s) && s != separator.ToString())
            {
                string strVal = s;
                if (toLower)
                {
                    strVal = s.ToLower();
                }

                list.Add(strVal);
            }
        }

        return list;
    }

    /// <summary>
    /// 把字符串转 按照, 分割 换为数据
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string[] GetStrArray(string str)
    {
        return str.Split(new char[] { ',' });
    }

    /// <summary>
    /// 把 List<string>按照分隔符组装成string
    /// </summary>
    /// <param name="list">源字符串列表</param>
    /// <param name="separator">分隔符</param>
    /// <returns></returns>
    public static string GetArrayStr(List<string> list, string separator)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < list.Count; i++)
        {
            if (i == list.Count - 1)
            {
                sb.Append(list[i]);
            }
            else
            {
                sb.Append(list[i]);
                sb.Append(separator);
            }
        }

        return sb.ToString();
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    /// TODO: 这个有点奇怪
    public static string GetArrayValueStr(Dictionary<int, int> list)
    {
        StringBuilder sb = new StringBuilder();
        foreach (KeyValuePair<int, int> kvp in list)
        {
            sb.Append(kvp.Value + ",");
        }

        if (list.Count > 0)
        {
            return DelLastComma(sb.ToString());
        }
        else
        {
            return "";
        }
    }

    #region 删除最后一个字符之后的字符

    /// <summary>
    /// 删除结尾最后一个逗号
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    /// TODO: 觉得这个方法处理的不好
    public static string DelLastComma(string str)
    {
        return str.Substring(0, str.LastIndexOf(",", StringComparison.Ordinal));
    }

    /// <summary>
    /// 删除最后结尾的指定字符串后的字符
    /// </summary>
    /// <param name="str">源字符串</param>
    /// <param name="strChar">指定删除的字符</param>
    /// <returns></returns>
    /// TODO: 其实有点问题在的要修改
    public static string DelLastChar(string str, string strChar)
    {
        return str.Substring(0, str.LastIndexOf(strChar, StringComparison.Ordinal));
    }

    #endregion 删除最后一个字符之后的字符

    /// <summary>
    /// 转全角的函数(SBC case)
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string ToSBC(string input)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///  转半角的函数(SBC case)
    /// </summary>
    /// <param name="input">输入</param>
    /// <returns></returns>
    public static string ToDBC(string input)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 把字符串按照指定分隔符装成list
    /// </summary>
    /// <param name="src"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    /// TODO: 感觉功能上和之前那个有点重复
    public static List<string> GetSubStringList(string src, char separator)
    {
        List<string> list = new List<string>();
        string[] ss = src.Split(separator);
        foreach (string s in ss)
        {
            if (!string.IsNullOrEmpty(s) || s != separator.ToString())
            {
                list.Add(s);
            }
        }

        return list;
    }

    #region 将字符串样式转换为纯字符串

    /// <summary>
    /// 将字符串样式转换为纯字符串
    /// </summary>
    /// <param name="strList"></param>
    /// <param name="splitStr"></param>
    /// <returns></returns>
    /// TODO: 非常奇怪
    public static string GetCleanStyle(string strList, string splitStr)
    {
        string retVal = "";
        if (strList == null)
        {
            retVal = "";
        }
        else
        {
            // 返回去掉分隔符
            string newStr = "";
            newStr = strList.Replace(splitStr, "");
            retVal = newStr;
        }

        return retVal;
    }

    #endregion 将字符串样式转换为纯字符串

    #region 将字符串转换为新样式

    /// <summary>
    /// 将字符串转换为新样式
    /// </summary>
    /// <param name="str"></param>
    /// <param name="newStyle"></param>
    /// <param name="splitStr"></param>
    /// <param name="error"></param>
    /// <returns></returns>
    public static string GetNewStyle(string str, string newStyle, string splitStr, out string error)
    {
        throw new NotImplementedException();
    }

    #endregion 将字符串转换为新样式

    /// <summary>
    /// 分割字符串
    /// </summary>
    /// <param name="str"></param>
    /// <param name="splitStr"></param>
    /// <returns></returns>
    public static string[] SplitMulti(string str, string splitStr)
    {
        string[] strArray = null!;
        if (!string.IsNullOrEmpty(str))
        {
            strArray = new Regex(splitStr).Split(str);
        }

        return strArray;
    }

    // TODO: 不是特别清楚具体要做什么
    public static string SqlSafeString(string str, bool isDel)
    {
        if (isDel)
        {
            str = str.Replace("'", "");
            str = str.Replace("\"", "");
        }

        str = str.Replace("'", "&#39;");
        str = str.Replace("\"", "&#34l");
        return str;
    }

    #region 获取正确的Id，如果不是正整数，返回0

    /// <summary>
    /// 获取正确的Id，如果不是正整数，返回0
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static int StrToId(string id)
    {
        if (IsNumberId(id))
        {
            return int.Parse(id);
        }

        return 0;
    }

    #endregion 获取正确的Id，如果不是正整数，返回0

    #region 检查一个字符串是否是纯数字构成的，一般用于查询字符串参数的有效性验证

    public static bool IsNumberId(string value)
    {
        return QuickValidate("^[1-9]*[0-9]*$", value);
    }

    #endregion 检查一个字符串是否是纯数字构成的，一般用于查询字符串参数的有效性验证

    #region 快速验证一个字符串是否符合指定的正则表达式

    /// <summary>
    /// 快速验证一个字符串是否符合指定的正则表达式
    /// </summary>
    /// <param name="regex">正则表达式</param>
    /// <param name="value">字符串</param>
    /// <returns></returns>
    public static bool QuickValidate(string regex, string value)
    {
        if (value == null)
        {
            return false;
        }

        if (value.Length == 0)
        {
            return false;
        }

        Regex myRegex = new Regex(regex);
        return myRegex.IsMatch(value);
    }

    #endregion 快速验证一个字符串是否符合指定的正则表达式

    #region 根据配置对指定字符串进行 MD5 加密

    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    /// TODO: 没测试过
    public static string GetMD5(string s)
    {
        // md5加密
        MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
        byte[] data = md5CryptoServiceProvider.ComputeHash(Encoding.Default.GetBytes(s));
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sb.Append(data[i].ToString("x2"));
        }

        return sb.ToString();
    }

    #endregion 根据配置对指定字符串进行 MD5 加密

    #region 得到字符串长度，一个汉字长度为2

    /// <summary>
    /// 得到字符串长度，一个汉字长度为2
    /// </summary>
    /// <param name="inputStr"></param>
    /// <returns></returns>
    public static int StrLength(string inputStr)
    {
        System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
        int tempLen = 0;
        byte[] s = ascii.GetBytes(inputStr);
        for (int i = 0; i < s.Length; i++)
        {
            if ((int)s[i] == 63)
            {
                tempLen += 2;
            }
            else
            {
                tempLen += 1;
            }
        }

        return tempLen;
    }

    #endregion 得到字符串长度，一个汉字长度为2

    #region 截取指定长度字符串

    /// <summary>
    /// 截取指定长度字符串
    /// </summary>
    /// <param name="inputStr">字符串</param>
    /// <param name="len">截取长度</param>
    /// <returns>返回处理后的字符串</returns>
    /// TODO: 不是很理解
    public static string ClipString(string inputStr, int len)
    {
        bool isShowFix = false;
        if (len % 2 == 1)
        {
            isShowFix = true;
            len--;
        }
        System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
        int tempLen = 0;
        string tempStr = "";
        byte[] s = ascii.GetBytes(inputStr);
        for (int i = 0; i < s.Length; i++)
        {
            if ((int)s[i] == 63)
            {
                tempLen += 2;
            }
            else
            {
                tempLen += 1;
            }

            try
            {
                tempStr += inputStr.Substring(i, 1);
            }
            catch
            {
                break;
            }

            if (tempLen > len)
            {
                break;
            }
        }

        byte[] myByte = System.Text.Encoding.Default.GetBytes(inputStr);
        if (isShowFix && myByte.Length > len)
        {
            tempStr += "...";
        }
        return tempStr;
    }

    #endregion 截取指定长度字符串

    #region HTML转行成TEXT

    public static string HtmlToText(string strHtml)
    {
        throw new NotImplementedException();
    }

    #endregion HTML转行成TEXT

    #region 判断对象是否为空

    public static bool IsNullOrEmpty(object data)
    {
        throw new NotImplementedException();
    }

    #endregion 判断对象是否为空
}