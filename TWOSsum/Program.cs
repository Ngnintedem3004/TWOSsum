// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TWOSsum;

Console.WriteLine("Hello, World!");
/*int[] TwoSum(int[] nums, int target)
{
   int[] indices = new int[2];
   int SumOfTwoNumbers;
   int j = 0;
   int k = 0;
   for (int i = 0; i < nums.Length; i++)
   {
       if (nums.Length > 2)
       {
           k = i + 1;
       }
       else
       {
           k = 1;
       }

       do
       {
           j = k;
           SumOfTwoNumbers = nums[i] + nums[j];

           if (SumOfTwoNumbers == target)
           {
               indices[0] = i;
               indices[1] = j;
               return indices;
           }
           k++;



       } while (j<nums.Length-1);

   }
   return indices;

}

var results = TwoSum([3,3], 6);
foreach (int v in results)
{
   Console.WriteLine(v);


}*/
/*int Reverse(int x)
{
   string strNumber = x.ToString();
   long reverse64;
   int reverse32;
   char[] arraystr = strNumber.ToCharArray();
   Array.Reverse(arraystr);
   string reverseStr = string.Concat(arraystr);
   if (reverseStr.EndsWith("-".ToString()))
   {
       reverseStr = reverseStr.Substring(0, reverseStr.Length - 1);
       reverse32 = Convert.ToInt32(reverseStr) * (-1);
       reverse64 = Convert.ToInt64(reverseStr) * (-1);
       if (reverse64 >= (-(Math.Pow(2, 31))) && reverse64 <= (Math.Pow(2, 31) - 1))
       {
           if (reverse32 >= (-(Math.Pow(2, 31))) && reverse32 <= (Math.Pow(2, 31) - 1))
           {
               return reverse32;
           }
           else
           {
               return 0;
           }
       }

       else
       {

           return 0;
       }
   }

   else
   {
       reverse64 = Convert.ToInt64(reverseStr);
       reverse32 = Convert.ToInt32(reverseStr);
       if (reverse64 >= (-(Math.Pow(2, 31))) && reverse64 <= (Math.Pow(2, 31) - 1))
       {
           if (reverse32 >= (-(Math.Pow(2, 31))) && reverse32 <= (Math.Pow(2, 31) - 1))
           {
               return reverse32;
           }
           else
           {
               return 0;
           }
       }
       else
       {
           return 0;
       }

   }

}
Reverse(1534236469);*/

/*int RomanToInt(string s)
{
   Dictionary<string, int> dictionnary = new Dictionary<string, int>{
        {"I",1},{"V",5},{"X",10},{"L",50},{"C",100},{"D",500},{"M",1000},
       };
   int sum = 0;
   string Ivalue = "I".ToString();
   string Vvalue = "V".ToString();
   string Xvalue = "X".ToString();
   string Lvalue = "L".ToString();
   string Cvalue = "C".ToString();
   string Dvalue = "D".ToString();
   string Mvalue = "M".ToString();
   for (int i = 0; i < s.Length; i++)
   {
       if (s[i].ToString() == Ivalue)
       {
           if (i == s.Length - 1)
           {
               sum = sum + dictionnary[s[i].ToString()];
               break;
           }
           if (s[i + 1].ToString() == Vvalue)
           {
               sum = sum + dictionnary["V"] - dictionnary["I"];
               i++;

               continue;
           }
           if (s[i + 1].ToString() == Xvalue)
           {
               sum = sum + dictionnary["X"] - dictionnary["I"];
               i++;
               continue;
           }
       }
       if (s[i].ToString() == Xvalue)
       {
           if (i == s.Length - 1)
           {
               sum = sum + dictionnary[s[i].ToString()];
               break;
           }
           if (s[i + 1].ToString() == Lvalue)
           {
               sum = sum + dictionnary["L"] - dictionnary["X"];
               i++;
               continue;
           }
           if (s[i + 1].ToString() == Cvalue)
           {
               sum = sum + dictionnary["C"] - dictionnary["X"];
               i++;
               continue;
           }
       }
       if (s[i].ToString() == Cvalue)
       {
           if (i == s.Length - 1)
           {
               sum = sum + dictionnary[s[i].ToString()];
               break;
           }
           if (s[i + 1].ToString() == Dvalue)
           {
               sum = sum + dictionnary["D"] - dictionnary["C"];
               i++;
               continue;
           }
           if (s[i + 1].ToString() == Mvalue)
           {
               if (i == s.Length - 1)
               {
                   sum = sum + dictionnary[s[i].ToString()];
                   break;
               }
               sum = sum + dictionnary["M"] - dictionnary["C"];
               i++;
               continue;
           }
       }

       sum = sum + dictionnary[s[i].ToString()];
   }


   return sum;



}
var value=RomanToInt("MCMXCIV");
Console.WriteLine(value);*/

/*   bool IsValid(string s)
{
  
    bool value=false;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].ToString()=="}".ToString() || s[i].ToString()=="]".ToString() || s[i].ToString() == ")".ToString())
        {
            return false;
        }
        if (s[i].ToString() == "[".ToString())
        {
            if (s[i + 1].ToString() == "]")
            {
                value = true;
                if (i == s.Length - 1)
                {
                    break;
                }
               
                i++;
                continue;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (s[i].ToString() == "(".ToString())
            {
                if (s[i + 1].ToString() == ")")
                {
                    value = true;
                    if (i == s.Length - 1)
                    {
                        break;
                    }
                    i++;
                    continue;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                if (s[i].ToString() == "{".ToString())
                {
                    if (s[i + 1].ToString() == "}")
                    {
                        value = true;
                        if (i == s.Length - 1)
                        {
                            break;
                        }
                        i++;
                        
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                    
                }
            }
        }
    }
    return value;
}

 /*int StrStr(string haystack, string needle)
{
    int index = 0;
    int j = 0;
    int k = 0;
    string str = "";
    List<int> list = new List<int>();
    if (haystack.Contains(needle))
    {
        if (haystack.StartsWith(needle))
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[i])
                {
                    list.Add(i);
                    str = str + haystack[i];
                    if (str == needle)
                    {
                        break;
                    }
                }
            }
        }
        else
        {
            do
            {
                if (haystack[k] == needle[j])
                {
                    list.Add(k);
                    str = str + haystack[j];

                    if (j == needle.Length - 1)
                    {

                        if (str == needle)
                        {
                            break;
                        }
                        else
                        {
                            list.RemoveAll(x => x > 0);
                            j = 0;
                        }
                    }

                }
                k++;
                j++;

            } while (k < haystack.Length);


        }
        index = list.Min();
        return index;
    }
    else
    {
        return -1;
    }


}
*/
/*int RemoveDuplicates( int[] nums)
{
bool isDuplicated=true;
    List<int> list = new List<int>();
    for (int i = 0; i < nums.Length-1; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
            {
                nums[j] = -101;
                if (nums[i] >= -100 && nums[i] <= 100)
                {
                if (!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                }
                }
            }
        else
        {
            isDuplicated = false;
        }
        }
    if (!isDuplicated)
    {
        if (i != nums.Length - 1)
        {
            if (nums[i] >= -100 && nums[i] <= 100)
            {
                if (!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                }
            }
        }
    }
    }
if (nums[nums.Length - 1] >= -100 && nums[nums.Length - 1] <= 100)
{
    if (!list.Contains(nums[nums.Length - 1]))
    {
        list.Add(nums[nums.Length - 1]);
    }
}
var array=list.ToArray();
for (int i=0;i<array.Length; i++)
{
    nums[i] = array[i];
}

return list.Count();

}
//RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);
int[] nums = [1,1, 2];
int[] expectedNums = [1,2]; // The expected answer with correct length

int k = RemoveDuplicates( nums); // Calls your implementation
Console.WriteLine(k);
/*foreach(int j in nums)
{
Console.WriteLine(j);
}
if (k == expectedNums.Length)
{


for (int i = 0; i < k; i++)
{
    if (nums[i] == expectedNums[i])
    {
        Console.WriteLine(nums[i]);
    }
}
}*/

/* IList<string> LetterCombinations(string digits)
{
    Dictionary<string, string> dictionary = new Dictionary<string, string>{
         {"2","abc"}, {"3","def"}, {"4","ghi"}, {"5","jkl"}, {"6","mno"}, {"7","pqrs"}, {"8","tuv"}, {"9","wxyz"}
     };
    string valueDigit = "";
    string KeyDigit = "";
    int n = 0;
    string valueDigit2;
    string valueDigit3;
    if (digits.Length > 0)
    {
        KeyDigit = dictionary[digits[0].ToString()];
    }
    string str = "";
    string str2 = "";
    string str3 = "";
    int k = 0;
    int l = 0;
    List<string> list = new List<string>();
    List<string> list2 = new List<string>();
    if (digits.Contains(" "))
    {
        return new List<string> { "" };
    }
    else
    {
        if (digits.Length == 1)
        {
            if (digits == "2")
            {
                Console.WriteLine(dictionary["2"].ToString());
                return new List<string> { "a", "b", "c" };
            }
            else
            {
                if (digits == "3")
                {
                    Console.WriteLine(dictionary["3"].ToString());
                    return new List<string> { "d", "e", "f" };
                }
                else
                {
                    if (digits == "4")
                    {
                        return new List<string> { "g", "h", "i" };
                    }
                    else
                    {
                        if (digits == "5")
                        {
                            return new List<string> { "j", "k", "l" };
                        }
                        else
                        {
                            if (digits == "6")
                            {
                                return new List<string> { "m", "n", "o" };
                            }
                            else
                            {
                                if (digits == "7")
                                {
                                    return new List<string> { "p", "q", "r", "s" };
                                }
                                else
                                {
                                    if (digits == "8")
                                    {
                                        return new List<string> { "t", "u", "v" };
                                    }
                                    else
                                    {
                                        if (digits == "9")
                                        {
                                            return new List<string> { "w", "x", "y", "z" };
                                        }

                                    }
                                }
                            }
                        }
                    }

                }
            }
        }
        else
        {
            // Adjust the code here 
            if (digits.Length == 2)
            {
                for (int i = 1; i < digits.Length; i++)
                {
                    valueDigit = dictionary[digits[i].ToString()];
                    for (int j = 0; j < dictionary[digits[i].ToString()].Length; j++)
                    {
                        do
                        {
                            if (j == KeyDigit.Length)
                            {
                                break;
                            }
                            str = str + KeyDigit[j] + valueDigit[k];
                            list.Add(str);
                            str = "";

                            k++;
                        } while (k < dictionary[digits[i].ToString()].Length);


                        k = 0;
                    }

                }
            }
            else
            {
                if (digits.Length == 3)
                {
                    // insert code here 
                    valueDigit2 = dictionary[digits[2].ToString()];
                    for (int i = 1; i < digits.Length - 1; i++)
                    {
                        valueDigit = dictionary[digits[i].ToString()];

                        for (int j = 0; j < dictionary[digits[i].ToString()].Length; j++)
                        {

                            do
                            {
                                if (j == KeyDigit.Length)
                                {
                                    break;
                                }
                                str = str + KeyDigit[j] + valueDigit[k];
                                do
                                {

                                    str2 = str + valueDigit2[l];
                                    list2.Add(str2);

                                    l++;
                                } while (l < dictionary[digits[2].ToString()].Length);

                                str = "";
                                l = 0;
                                k++;
                            } while (k < dictionary[digits[i].ToString()].Length);


                            k = 0;
                        }
                    }
                    foreach (string item in list2)
                    {
                        Console.WriteLine(item);
                    }
                    return list2;
                }

                else if (digits.Length == 4)
                {

                    // insert code here 
                    valueDigit2 = dictionary[digits[2].ToString()];
                    valueDigit3 = dictionary[digits[3].ToString()];
                    for (int i = 1; i < digits.Length - 2; i++)
                    {
                        valueDigit = dictionary[digits[i].ToString()];

                        for (int j = 0; j <=dictionary[digits[i].ToString()].Length; j++)
                        {

                            do
                            {
                                if (j == KeyDigit.Length)
                                {
                                    break;
                                }
                                str = str + KeyDigit[j] + valueDigit[k];
                                do
                                {

                                    str2 = str + valueDigit2[l];
                                    do
                                    {
                                        str3 = str2 + valueDigit3[n];
                                        list2.Add(str3);
                                        n++;
                                    } while (n < dictionary[digits[3].ToString()].Length);
                                    l++;
                                    n = 0;
                                } while (l < dictionary[digits[2].ToString()].Length);
                                l = 0;
                                str = "";
                                k++;
                            } while (k < dictionary[digits[i].ToString()].Length);


                            k = 0;
                        }
                    }
                    foreach (string item in list2)
                    {
                        Console.WriteLine(item);
                    }
                    return list2;
                }

            }
        }

    }


    return list;
}*/
/*var value = LetterCombinations("9387");
Console.WriteLine(value);*/

//var value = RemoveDuplicates([1, 1, 2]);
//Console.WriteLine(value); 
//var value = IsValid("}{}{{");
/*var value2 = StrStr("mississippi", "issi");
Console.WriteLine(value2);
//Console.WriteLine(value);*/
/*unsafe
{
    int number = 27;
    int* pointerToNumber = &number;
    Console.WriteLine($"Valeur de la variable : {number}");
    Console.WriteLine($"Adresse de la variable : {(long)pointerToNumber:X}");
    int number = 27;
    int* pointerToNumber = &number;
    int value = *pointerToNumber;
    Console.WriteLine($"Valeur pointée : {value}");
}*/


/*string LongestPalindrome(string s)
{
   string str = "";
   List<string> ListPalindrom = new List<string>();
   if (s == ReverseString(s))
   {
       return s;
   }

   if (s.Length == 1)
   {
       return s;
   }
   else
   {
       if (s.Length == 2)
       {
           if (s == ReverseString(s))
           {
               return s;
           }
           return s[0].ToString();
       }
       else
       {
           for (int i = 0; i < s.Length; i++)
           {
               str = s[i].ToString();
               for (int j = i + 1; j < s.Length; j++)
               {
                   str = str + s[j];
                   if (str == ReverseString(str))
                   {

                       ListPalindrom.Add(str);
                   }
               }

           }
       }
   }
   string chaineLaPlusLongue = ListPalindrom.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
   return chaineLaPlusLongue;

}

string ReverseString(string s)
{
   char[] CharArray = s.ToCharArray();
   Array.Reverse(CharArray);
   string stringReverse = new string(CharArray);
   return stringReverse;
}*/
//var longstring = LongestPalindrome("xaaaabbbbbbbbbbccccccccccddddddddddeeeeeeeeeeffffffffffgggggggggghhhhhhhhhhiiiiiiiiiijjjjjjjjjjkkkkkkkkkkllllllllllmmmmmmmmmmnnnnnnnnnnooooooooooppppppppppqqqqqqqqqqrrrrrrrrrrssssssssssttttttttttuuuuuuuuuuvvvvvvvvvvwwwwwwwwwwxxxxxxxxxxyyyyyyyyyyzzzzzzzzzzyyyyyyyyyyxxxxxxxxxxwwwwwwwwwwvvvvvvvvvvuuuuuuuuuuttttttttttssssssssssrrrrrrrrrrqqqqqqqqqqppppppppppoooooooooonnnnnnnnnnmmmmmmmmmmllllllllllkkkkkkkkkkjjjjjjjjjjiiiiiiiiiihhhhhhhhhhggggggggggffffffffffeeeeeeeeeeddddddddddccccccccccbbbbbbbbbbaaaaaaaabbbbbbbbbbccccccccccddddddddddeeeeeeeeeeffffffffffgggggggggghhhhhhhhhhiiiiiiiiiijjjjjjjjjjkkkkkkkkkkllllllllllmmmmmmmmmmnnnnnnnnnnooooooooooppppppppppqqqqqqqqqqrrrrrrrrrrssssssssssttttttttttuuuuuuuuuuvvvvvvvvvvwwwwwwwwwwxxxxxxxxxxyyyyyyyyyyzzzzzzzzzzyyyyyyyyyyxxxxxxxxxxwwwwwwwwwwvvvvvvvvvvuuuuuuuuuuttttttttttssssssssssrrrrrrrrrrqqqqqqqqqqppppppppppoooooooooonnnnnnnnnnmmmmmmmmmmllllllllllkkkkkkkkkkjjjjjjjjjjiiiiiiiiiihhhhhhhhhhggggggggggffffffffffeeeeeeeeeeddddddddddccccccccccbbbbbbbbbbaaaa");
//Console.WriteLine(longstring);
/*string  Convert(string s, int numRows)
{
   List<string> ListRows = new List<string>();
   int j = 0;
   int k = 0;
   if (s.Length == 1)
   {
       return s;
   }
   if (s.Length < numRows || numRows==1) {  return s; }
   else
   {
       for (int i = 0; i < numRows; i++)
       {
           ListRows.Add(s[i].ToString());
       }

           for (int i = 0; i < numRows; i++)
           {
               ListRows[i] = s[i].ToString();
           }

       j = numRows;
       if (s.Length > 2)
       {
           k = numRows - 2;
       }
       else
       {
           k = numRows - 1;
       }

       do
       { 
           do
           {
               if (j == s.Length)
               {
                   break;
               }
               ListRows[k] += s[j];
               var str = ListRows[k];
               Console.WriteLine(str);
               j++;
               k--;
           } while (k > 0);
           if (ListRows.Count() > 2)
           {
               k = 0;
           }
           else
           {
               k = 1;
           }
           do
           {
               if (j == s.Length)
               {
                   break;
               }
               ListRows[1] += s[j];
               j++;
               k++;
           } while (k<numRows);
           k=numRows-2;

       } while (j<s.Length);
   }
  var  result = ListRows.ToArray();
   foreach(var row in result)
   {
       Console.WriteLine(row);
   }
   return string.Join("",result);
}
Console.WriteLine(Convert("ABCDLORENNEDMOPO", 4));
*/
int result = Fibonacci(5);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    Console.WriteLine("The output is :");
    int n1 = 10;
    int n2 = 1;
    Debug.Write("Debug - ------");
    Debug.WriteLine("This is a  ffjhh full line.");
    Debug.WriteLine("This is another full line.");

    int sum;

    for (int i = 2; i < n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    return n == 0 ? n1 : n2;
}


Console.ReadLine();
/*public class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Subtract(int x, int y)
    {
        return x - y;
    }

    public int Multiply(int x, int y)
    {
        return x * y;
    }

    public int Divide(int x, int y)
    {
        return x / y;
    }
}*/
