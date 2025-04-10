using System.Collections.Generic;
using System;
namespace csharp_course;
public class Kata
{
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