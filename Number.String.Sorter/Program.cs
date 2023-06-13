// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

Console.WriteLine("Hello, World!");
var currentDir = Helpers.GetParentDirectory(4, Directory.GetCurrentDirectory());
var filePath = Path.Combine(currentDir, "file.txt");
Console.WriteLine(filePath);
NumberStringSorter.ReadFile(filePath);
Console.ReadKey();


