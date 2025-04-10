using System.Collections.Generic;
using System;
using System.Text;
using System.Globalization;
using System.Runtime.InteropServices;
namespace csharp_course;
public class Kata
{
     public static string UInt32ToIP(uint ip)
  {
    if(ip>0)
    {
        var binFormat = Convert.ToString(ip,2);
        StringBuilder binBuilder = new();
        for(int j = 32-binFormat.Length;j>0;j--){
            binBuilder.Append("0");
        }
        binFormat = binBuilder.Append(binFormat).ToString();
        string[] parts = new string[4];
        for(int i=0; i<binFormat.Length;i+=8){
            parts[i/8]=binFormat.Substring(i,8);
        }
        StringBuilder ipBuilder = new();
        foreach(var numb in parts){
            ipBuilder.Append(Convert.ToUInt32(numb,2));
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
        for(int i = 0;i<s.Length;i++){
            string sub = s.Substring(i,1).ToLower();
            if(lettersInd.Keys.Contains(sub)){
                lettersInd[sub]=-1;
            }
            else{
                lettersInd[sub] = i;
            }
        }
        foreach(var key in lettersInd.Keys){
            if(lettersInd[key]>=0){
                return s.Substring(lettersInd[key],1);
            }
        }
        return "";
  }
}