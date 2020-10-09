using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class MyString
    {
        public char[] MyWord;
        public MyString(char[] word)
        {          
            MyWord = word;                  
        }
        
       public static char[] operator +(MyString myString1, MyString myString2)
       {
            char[] ResultChar = new char[myString1.MyWord.Length + myString2.MyWord.Length];
            for (int i = 0; i < myString1.MyWord.Length; i++)
            {             
              ResultChar[i] = myString1.MyWord[i];              
            }
            int k = 0;
            for (int i = myString1.MyWord.Length; i < ResultChar.Length; i++)
            {                            
               ResultChar[i] = myString2.MyWord[k];
                k+=1;             
            }
            return ResultChar;
       }
        
      public static char[] operator -(MyString myString1, MyString myString2)
      {
            char[] char1 = myString1.MyWord; char[] char2 = myString2.MyWord;
            int n = char1.Length - char2.Length;
            char[] ResultChar;            
            int j=0; int i = 0; bool found = false;
            int[] index =new int[char2.Length];
            while ((i <= n) && !found)
            {
                j = Array.IndexOf(char1, char2[0], i);
                if(j==-1)
                {
                    return char1;
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
                ResultChar = new char[char1.Length - char2.Length]; 
                int k = 0; int m = 0;int ind = 0;
                while( m<ResultChar.Length)
                {                
                       if ((k<index.Length) && (ind == index[k]))
                        {
                            k += 1;
                            ind += 1;
                        }                  
                    else
                    {
                        ResultChar[m] = char1[ind];
                        m += 1;
                        ind += 1;
                    }
                }
                return ResultChar;
            }
            else
            return char1;
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

            if (myString1.MyWord.Length == myString2.MyWord.Length)
                {
                    for (int i = 0; i < myString1.MyWord.Length; i++)
                    {
                        if (myString1.MyWord[i] != myString2.MyWord[i])
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
            if (myString1.MyWord.Length == myString2.MyWord.Length)
            {
                for (int i = 0; i < myString1.MyWord.Length; i++)
                {
                    if (myString1.MyWord[i] != myString2.MyWord[i])
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
            string Result="";
            for (int i = 0; i < MyWord.Length; i++)
            {
                Result += MyWord[i];
            }
            return Result;
      }
      
    }
}
