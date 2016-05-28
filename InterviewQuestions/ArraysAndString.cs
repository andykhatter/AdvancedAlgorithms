using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{/*
  * ASCII has 128 code points, 0 through 127. It can fit in a single 8-bit byte, the values 128 through 255 tended to be used for other characters. With incompatible choices, causing the code page disaster. Text encoded in one code page cannot be read correctly by a program that assumes or guessed at another code page.

Unicode came about to solve this disaster. Version 1 started out with 65536 code points, commonly encoded in 16 bits. Later extended in version 2 to 1.1 million code points. The current version is 6.3, using 110,187 of the available 1.1 million code points. That doesn't fit in 16 bits anymore.

Encoding in 16-bits was common when v2 came around, used by Microsoft and Apple operating systems for example. And language runtimes like Java. The v2 spec came up with a way to map those 1.1 million code points into 16-bits. An encoding called UTF-16, a variable length encoding where one code point can take either 2 or 4 bytes. The original v1 code points take 2 bytes, added ones take 4.

Another variable length encoding that's very common, used in *nix operating systems and tools is UTF-8, a code point can take between 1 and 4 bytes, the original ASCII codes take 1 byte the rest take more. The only non-variable length encoding is UTF-32, takes 4 bytes for a code point. Not often used since it is pretty wasteful. There are other ones, like UTF-1 and UTF-7, widely ignored.

An issue with the UTF-16/32 encodings is that the order of the bytes will depend on the endian-ness of the machine that created the text stream. So add to the mix UTF-16BE, UTF-16LE, UTF-32BE and UTF-32LE.

Having these different encoding choices brings back the code page disaster to some degree, along with heated debates among programmers which UTF choice is "best". Their association with operating system defaults pretty much draws the lines. One counter-measure is the definition of a BOM, the Byte Order Mark, a special codepoint (U+FEFF, zero width space) at the beginning of a text stream that indicates how the rest of the stream is encoded. It indicates both the UTF encoding and the endianess and is neutral to a text rendering engine. Unfortunately it is optional and many programmers claim their right to omit it so accidents are still pretty common.
  */
    public class ArraysAndString
    {
        /// <summary>
        /// Implement an algorithm to determine if a string has all unique characters.what if you cannot use additional datastructures
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool DetermineUniqueCharacters(string input)
        {
            HashSet<char> unique = new HashSet<char>();
            foreach (char s in input)
            {
                if (unique.Add(s))
                {
                    continue;
                }

                else
                    return false;
            }

            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool DetermineUniqueCharactersNoSet(string input)
        {
            
            for (int i =0;i<input.Length;i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i == j) continue;
                    else if(input[i]==input[j]) 
                    {
                        return false;

                    }
                }
                
             }

            return true;
        }
        /// <summary>
        /// ask if anagram anagram?if length is equal: sort the strings and match,Given two strings write a method to decide if one is a permutation of the other
        /// </summary>
        /// <param name="orig"></param>
        /// <param name="permutation"></param>
        /// <returns></returns>
        public bool IsStringAPermutation(string orig, string permutation)
        {
            
            var ans = orig.Intersect(permutation);
            string answer=string.Concat(ans.Select(c=>c));
            if (answer == permutation)
                return true;
            return false;
        }

        /// <summary>
        /// Write a mehod to replace all spances in a string with '%20' . You may assume that the string has sufficient space at the end of the string to hold the additional characters and that you are given the "true" length of the string 
        /// (Note:if implementing in java,please use a character array so that you can perform this operation in place)
        /// Example:
        /// Input: "Mr John Smith   "
        /// output: "Mr%20john%20Smith"
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>


        public string ReplaceSpaces(string input)
        {
            string newChar="%20";
            string retString = "";
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    retString = retString + newChar;
                }
                else
                {
                    retString = retString + c.ToString();
                }
                    
            }
            return retString;
        }

        /// <summary>
        /// Implement a method to perform basic string compressions using the counts of repeated characters .For example the string aabcccccaaa would become a2b1c5a3.If the compressed string woulf not become smaller than the original string your method nshould return the original string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string CompressStriong(string input)
        {
            string compressedString = "";
            // it will be of same length when all the characters are unique? ascii or unicode.[256] boolean 
            // will the repeated char always exist consecutively? o(1) ?
            //writing the solution assuing no they dont.
            int count=0;
            StringBuilder output = new StringBuilder();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in input)
            {
                count=dict.ContainsKey(c)?dict[c]++:0;
                if (count == 0) dict.Add(c, 1);
            }
            foreach (char key in dict.Keys)
            {
                output.Append(key.ToString() + dict[key].ToString());
            }
            compressedString = output.ToString();



            return compressedString.Length == input.Length ? input : compressedString;
        }

        /// <summary>
        /// check if a string is rotated i.e if blempro is a rotation of problem
        /// </summary>
        /// <param name="input"></param>
        /// <param name="rotatedInput"></param>
        /// <returns></returns>
        public bool IsRotation(string input ,string rotatedInput)
        {

            return (input.Length != rotatedInput.Length) && (input + input).IndexOf(rotatedInput) > 0;
        }




    }
}
