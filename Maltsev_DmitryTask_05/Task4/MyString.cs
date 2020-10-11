using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class MyString
    {
        private char[] myWord;
        public MyString(string word)
        {
            myWord = word.ToCharArray();                 
        }
                  
       public static MyString operator +(MyString myString1, MyString myString2)
       {
            char[] resultChar = new char[myString1.myWord.Length + myString2.myWord.Length];
            for (int i = 0; i < myString1.myWord.Length; i++)
            {             
              resultChar[i] = myString1.myWord[i];              
            }
            int k = 0;
            for (int i = myString1.myWord.Length; i < resultChar.Length; i++)
            {                            
               resultChar[i] = myString2.myWord[k];
               k+=1;             
            }
            string resultString = new string(resultChar);
            MyString myString3 = new MyString(resultString);
            return myString3;
       }
        
      public static MyString operator -(MyString str1, MyString str2)
      {
            MyString str3;
            string resultString;
            char[] char1 = str1.myWord;
            char[] char2 = str2.myWord;
            int n = char1.Length - char2.Length;
            char[] resultChar;            
            int j=0; int i = 0; bool found = false;
            int[] index =new int[char2.Length];
            while (i <= n && !found)
            {
                j = Array.IndexOf(char1, char2[0], i);
                if(j==-1)
                {
                    resultString = new string(char1);
                    return str3=new MyString(resultString);
                }
                if((j<=n))
                {
                    found = true;
                    int k = 0;               
                    while ((k<char2.Length)&&found)
                    {
                        found = char.Equals(char1[k + j],char2[k]);
                        index[k] = (k + j);                    
                        k++;
                    }                 
                }
                i = j + 1;          
            }         
            if(found)
            {
                resultChar = new char[char1.Length - char2.Length]; 
                int k = 0; int m = 0;int ind = 0;
                while( m<resultChar.Length)
                {                
                       if ((k<index.Length) && (ind == index[k]))
                        {
                            k += 1;
                            ind += 1;
                        }                  
                    else
                    {
                        resultChar[m] = char1[ind];
                        m += 1;
                        ind += 1;
                    }
                }             
                resultString = new string(resultChar);
                return str3 = new MyString(resultString);
            }
            else
                resultString = new string(char1);
                return str3 = new MyString(resultString);
        }       

      public static bool operator ==(MyString myString1, MyString myString2)
      {
            bool isEqual = false;
            if(ReferenceEquals(myString1, null))
            {
                return isEqual=false;
            }
            if (ReferenceEquals(myString2, null))
            {
                return isEqual = false;
            }

            if (myString1.myWord.Length == myString2.myWord.Length)
                {
                    for (int i = 0; i < myString1.myWord.Length; i++)
                    {
                        if (myString1.myWord[i] != myString2.myWord[i])
                        {
                            isEqual = false;
                            break;
                        }
                        isEqual = true;
                    }
                }           
            return isEqual;
      }

        public static bool operator !=(MyString myString1, MyString myString2)
      {
            bool IsNotEqual = true;
            if (myString1.myWord.Length == myString2.myWord.Length)
            {
                for (int i = 0; i < myString1.myWord.Length; i++)
                {
                    if (myString1.myWord[i] != myString2.myWord[i])
                    {
                        IsNotEqual = true;
                        break;
                    }
                    IsNotEqual = false;
                }
            }
            return IsNotEqual;

        }
      public override string ToString()
      {
         string result = new string(myWord);
         return result;
      }     
    }
}
