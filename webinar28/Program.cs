﻿using System;
using System.IO;

namespace webinar28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            string currentDir = Directory.GetCurrentDirectory();

            string site = currentDir + @"\site";

            DumbHttpServer server = new DumbHttpServer(site, 8888);
        }
    }
}
