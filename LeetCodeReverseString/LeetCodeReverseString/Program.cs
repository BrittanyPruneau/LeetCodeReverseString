using System;

namespace LeetCodeReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "a!!!b.c.d,e'f,ghi";
            char[] charArray = str.ToCharArray();

            Console.WriteLine("Input string: " + str);
            reverse(charArray);
            String revStr = new String(charArray);

            Console.WriteLine("Output string: " + revStr);
            

            //METHOD 

            static void reverse(char[] str)
            {
                // Initialize left and right pointers  
                int r = str.Length - 1, l = 0;

                // Traverse string from both ends until  
                // 'l' and 'r'  
                while (l < r)
                {
                    // Ignore special characters  
                    if (!Char.IsLetter(str[l]))
                    {
                        ++l;

                    }
                    if (!Char.IsLetter(str[r]))
                    {
                        --r;
                    }

                    else
                    {
                        // "a!!!b.c.d,e'f,ghi"

                        // Both str[l] and str[r] are not spacial  


                        char tmp = str[l];
                        str[l] = str[r];
                        str[r] = tmp;
                        l++;
                        r--;

                    }

                    //char ch = '9';
                    //bool j = true;
                    //Console.WriteLine(Char.IsLetter(ch));
                    //Console.WriteLine(!Char.IsLetter(ch));


                }
            }
        }
    }
}
        
    
// when you say Mammal bessy = new Cow(); 
