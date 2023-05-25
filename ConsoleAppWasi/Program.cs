
using System.Runtime.InteropServices;

Console.WriteLine($"Hello Code Europe 2023 from {RuntimeInformation.OSArchitecture}!");

var file = System.IO.File.ReadAllText("/etc/hosts");
Console.WriteLine(file);