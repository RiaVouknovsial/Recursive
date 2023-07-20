// Написать программу рекурсивного обхода каталогов на диске

using System;
using System.IO;


    string path = @"C:\";
    RecursiveDirectoryTraversal(path);
    Console.WriteLine("Обход каталогов диска завершен");
    Console.ReadLine();
    

    static void RecursiveDirectoryTraversal(string path)
    {
        try
        {
           string[] items = Directory.GetFileSystemEntries(path);

            foreach (string item in items)
            {
                if (Directory.Exists(item))  
                {
                  RecursiveDirectoryTraversal(item);
                }
                else
                {
                  Console.WriteLine(item);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка: " + e.Message);
        }
    }





