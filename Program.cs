using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment1_Spring2020_AB
{
    class Program
    {

        public static void Main(string[] args)
        
    {  //Question 1

        for (int n = 5; n >= 1;n--)

        {

            for (int j = n; j >= 1; j--)

            Console.Write(j.ToString());
            Console.WriteLine();


        }

        Console.WriteLine();

        }
       
//Question 2
        {
            int i = 6;
            int k = 0;
            for (int n = 1; n <= i; n = n + 1)

            {
                
                 k = k + n;

                Console.Write(k+" ");

              
            }

            Console.WriteLine();

            



        //Question 3
        
        public static string UsfTime(string s)

        {
            
            Console.WriteLine("Please enter time in hh:mm:ss am/pm format");
            string input = Convert.UsfTime(Console.ReadLine());



        }




        //Question 4

        {
            for (int n = 1; n <= 110; n++)
            {
              
                    if (n % 3 == 0 || n % 5 == 0 || n % 7 == 0)

                    {
                    if (n % 3 == 0)
                    { 
                        Console.Write("U"+" ");
                    }
                    if (n % 5 == 0)
                    { 
                        Console.Write("S"+" "); 
                    }
                    if (n % 7 == 0)
                    { 
                        Console.Write("F"+" ");
                    }


                }
                    
                        else
                {
                    Console.Write(n.ToString()+" ");
                }
            if (n % 11 == 0)
            {
                Console.WriteLine();
            }


            }
                    
                    
                }

        
                    
                  
        

        //Question 5

        class pali1
        { 
        public static Boolean isPalindrome(String str)
        {
            int len = str.Length;

            // compare each character from starting 
            // with its corresponding character from last 
            for (int i = 0; i < len / 2; i++)
                if (str[i] != str[len - i - 1])
                    return false;

            return true;
        }

            static Boolean checkPalindromePair(List<String> vect)
            {
                // Consider each pair one by one 
                for (int i = 0; i < vect.Count - 1; i++)
                {
                    for (int j = i + 1; j < vect.Count; j++)
                    {
                        String check_str = "";

                        // concatenate both strings 
                        check_str = check_str + vect[i] + vect[j];

                        // check if the concatenated string is 
                        // palindrome 
                        if (isPalindrome(check_str))
                            return true;


                        check_str = vect[j] + vect[j];

                        // check if the concatenated string is 
                        // palindrome 
                        if (isPalindrome(check_str))
                            return true;
                    }
                }
                return false;
            }
            public static void Main(String[] args)
            {
                ArrayList a1 = new ArrayList();

                a1.Add("abcd");
                a1.Add("dcba");
                a1.Add("lls");
                a1.Add("s");
                a1.Add("sssll");

                

                if (checkPalindromePair(a1) == true)
                    Console.WriteLine(a1[0]);
                else
                    Console.WriteLine("No");
            }
        }
    }
    
     
     //Question 6
            public static void Stones(int n4)
            {
                try
                {
                     if (n4%4 !=0 )
                {
                    Console.WriteLine("One set of moves:"+n4); 

                }
                else
                {
                    Console.WriteLine("False");
                }
            
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing Stones()");
                }
            }
            








