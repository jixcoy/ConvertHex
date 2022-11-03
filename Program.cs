using System;
using System.Text;

namespace HexConverter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string teh = "hello world";
            ConvertHex(teh);
        }

        public static void ConvertHex(string s)
        {
            foreach (byte b in Encoding.ASCII.GetBytes(s)) Console.Write(Convert.ToString(b, 16) + " ");
        }
    }
}