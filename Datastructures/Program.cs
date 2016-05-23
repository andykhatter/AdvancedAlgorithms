using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using AdvancedDatastructures.BSTimpl;

namespace AdvancedDatastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList test = new ArrayList();

            test.Add("test");
            test.Add("test");
            test.Add("test");

            foreach (string s in test)
            {
                Console.WriteLine(s);
            }

            test.Remove("test");

            BinarySearchTree nums = new BinarySearchTree();
            nums.insert(50);
            nums.insert(30);
            nums.insert(60);
            //nums.insert(20);
            //nums.insert(30);
            //nums.insert(40);
            //nums.insert(60);
            //nums.insert(70);
            Console.WriteLine("inorder traversal...");
            nums.inorder(nums.root);

            Console.WriteLine("preorder traversal...");
            nums.preorder(nums.root);

            Console.WriteLine("postorder traversal...");
            nums.postorder(nums.root);

            Console.WriteLine("min value is...");
                nums.MinVal();

                Console.WriteLine("max value is...");
                nums.MaxVal();

                Console.WriteLine(nums.findHeight(nums.root) + "--ToTAL HEIGHT");
                Console.WriteLine(nums.checkHeightBalance(nums.root)+ "--TREE BALANCE");

                Console.WriteLine("Fibonacci number");
                long num = recFib(10);
            Console.WriteLine(num);

            Console.WriteLine(ReverseString_Rec("abcdef"));



            

        }

        public void TestArrayList()
        {
 
        }


       public static string ReverseString_Rec(string str)
        {
            Console.WriteLine(str);
            if (str.Length <= 1)
                return str;
            else
                return ReverseString_Rec(str.Substring(1)) +str[0];
        }

        //static string recRevString(String str, int len)
        //{
        //    if (len == 1)
        //    {
        //        return str;

        //    }


        //   // return recRevString(str);
            
        //}

        static long recFib(int n)
        {
            if (n < 2)
                return n;
            else
                return recFib(n - 1) + recFib(n - 2);
        }

        public static string ReverseString(string input)
        {
            //input = "Hello how are you";
            string reversedString="";

          //  Char[] chars = reversedString.ToCharArray();
            for (int i = input.Length-1; i>=0; i--)
            {
                reversedString += input[i];
            }

                return reversedString;

        }

        public static string ReverseBetter(string input)
        {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
        public static string ReverseWordsInString(string input)
        {
           // input="how are you";
            //string reversed = "";
            StringBuilder builder = new StringBuilder();
            //string[] temp=new string[100];
            ArrayList temp = new ArrayList();
           // char[] chars = input.ToCharArray();
           // int k = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
               // char whitespace = (char)input[i];
                if (input[i].ToString()!=" ")
                {
                    Console.WriteLine(input[i]);
                    temp.Add(input[i].ToString());
                    
                    
                }

                else if (input[i].ToString() == " " || i==0)
                {
                    if (temp.Count > 0)
                    {
                       // temp.Reverse();


                        for (int j = temp.Count - 1; j >= 0; j--)
                        {
                            Console.WriteLine(temp[j]);
                           // string temp2 = temp[j].ToString();
                            builder.Append(temp[j].ToString());
                            
                        }
                        temp.Clear();
                    }
                    builder.Append(" ");
                    
                }
                
            }
            Console.WriteLine(builder.ToString());
            return builder.ToString(); ;
        }
    }
}
