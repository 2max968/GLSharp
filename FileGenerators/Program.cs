﻿// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Globalization;

Console.WriteLine("Hello, World!");

Type t = typeof(Color);

var colors = t.GetProperties()
    .Where(p => p.PropertyType == typeof(Color))
    .Select(p => (p.Name, (Color?)p.GetValue(null)))
    .Where(c => c.Item2.HasValue)
    .Select(c => (c.Item1, c.Item2.Value))
    .ToList();

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

foreach (var color in colors)
{
    if (color.Item2.A == 255)
    {
        var r = color.Value.R;
        var g = color.Value.G;
        var b = color.Value.B;
        Console.WriteLine("\t\t///<summary>");
        Console.WriteLine("\t\t///#{0:X2}{1:X2}{2:X2}", r, g, b);
        Console.WriteLine("\t\t///</summary>");
        Console.WriteLine("\t\tpublic static readonly Color4 {0} = new Color4({1}f, {2}f, {3}f);",
            color.Item1, color.Value.R / 255f, color.Value.G / 255f, color.Value.B / 255f);
    }
}