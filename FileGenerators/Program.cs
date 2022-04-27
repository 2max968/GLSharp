// See https://aka.ms/new-console-template for more information
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Globalization;

Console.WriteLine("(C)olors, (E)nable Flags");
char chr = Console.ReadKey().KeyChar;
Console.Clear();

if (chr == 'c')
{
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
            Console.WriteLine("\t\t///hex = #{0:X2}{1:X2}{2:X2}, rgb = ({0},{1},{2})", r, g, b);
            Console.WriteLine("\t\t///</summary>");
            Console.WriteLine("\t\tpublic static readonly Color4 {0} = new Color4({1}f, {2}f, {3}f);",
                color.Item1, color.Value.R / 255f, color.Value.G / 255f, color.Value.B / 255f);
        }
    }
}
else if (chr == 'e')
{
    Type t = typeof(EnableCap);
    string[] names = Enum.GetNames(t);
    for (int i = 0; i < names.Length; i++)
    {
        var value = Enum.Parse<EnableCap>(names[i]);
        Console.WriteLine($"\t\tpublic static bool {names[i]}");
        Console.WriteLine("\t\t{");
        Console.WriteLine($"\t\t\tget => GL.IsEnabled({(int)value});");
        Console.WriteLine($"\t\t\tset => setEnabled({(int)value}, value);");
        Console.WriteLine("\t\t}");
    }
}