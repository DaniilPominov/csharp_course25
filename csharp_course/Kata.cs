using System.Numerics;
using System.Text;
namespace csharp_course;
public class Kata
{
    public static string sumStrings(string a, string b)
    {
        if (a == "")
            a = "0";
        if (b == "")
            b = "0";
        StringBuilder ABuilder = new();
        StringBuilder BBuilder = new();
        var maxLen = Math.Max(a.Length, b.Length);
        for (int j = maxLen - a.Length + 1; j > 0; j--)
        {
            ABuilder.Append("0");
        }
        for (int j = maxLen - b.Length + 1; j > 0; j--)
        {
            BBuilder.Append("0");
        }
        a = ABuilder.Append(a).ToString();
        b = BBuilder.Append(b).ToString();

        StringBuilder sb = new();
        int transfer = 0;
        for (int i = a.Length - 1; i > 0; i--)
        {
            var s = a[i] - 48 + b[i] - 48;
            s+=transfer;
            if(transfer>0)
            transfer--;
            if(s>=10){
                transfer++;
            }
            sb.Append(s%10);
        }
        sb.Append(transfer);
        var res = Reverse(sb.ToString());
        return res.TrimStart('0');
    }
    public static string Reverse( string s )
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
    public static string UInt32ToIP(uint ip)
    {
        if (ip > 0)
        {
            var binFormat = Convert.ToString(ip, 2);
            StringBuilder binBuilder = new();
            for (int j = 32 - binFormat.Length; j > 0; j--)
            {
                binBuilder.Append("0");
            }
            binFormat = binBuilder.Append(binFormat).ToString();
            string[] parts = new string[4];
            for (int i = 0; i < binFormat.Length; i += 8)
            {
                parts[i / 8] = binFormat.Substring(i, 8);
            }
            StringBuilder ipBuilder = new();
            foreach (var numb in parts)
            {
                ipBuilder.Append(Convert.ToUInt32(numb, 2));
                ipBuilder.Append(".");
            }
            var res = ipBuilder.ToString().Trim('.');
            return res;
        }
        return "0.0.0.0";
    }
    public static string FirstNonRepeatingLetter(string s)
    {
        Dictionary<string, int> lettersInd = new();
        for (int i = 0; i < s.Length; i++)
        {
            string sub = s.Substring(i, 1).ToLower();
            if (lettersInd.Keys.Contains(sub))
            {
                lettersInd[sub] = -1;
            }
            else
            {
                lettersInd[sub] = i;
            }
        }
        foreach (var key in lettersInd.Keys)
        {
            if (lettersInd[key] >= 0)
            {
                return s.Substring(lettersInd[key], 1);
            }
        }
        return "";
    }
}