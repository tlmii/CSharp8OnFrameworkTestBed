using System;

namespace CSharp8OnFrameworkTestBed
{
    public class PatternMatching
    {
        // Switch Expressions
        public enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet
        }

        public class RGBColor
        {
            public byte R { get; }
            public byte G { get; }
            public byte B { get; }
            public RGBColor(byte r, byte g, byte b)
            {
                R = r;
                G = g;
                B = b;
            }
        }

        public static RGBColor FromRainbow(Rainbow colorBand) =>
           colorBand switch
           {
               Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
               Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
               Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
               Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
               Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
               Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
               Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
               _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
           };

        // Property Patterns
        public class Address
        {
            public string State { get; set; }
        }

        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
            location switch
            {
                { State: "WA" } => salePrice * 0.06M,
                { State: "MN" } => salePrice * 0.075M,
                { State: "MI" } => salePrice * 0.05M,
                // other cases removed for brevity...
                _ => 0M
            };

        // Tuple Patterns
        public static string RockPaperScissors(string first, string second) =>
            (first, second) switch
            {
                ("rock", "paper") => "rock is covered by paper. Paper wins.",
                ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                ("paper", "rock") => "paper covers rock. Paper wins.",
                ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
                ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
                ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
                (_, _) => "tie"
            };


        // Positional Patterns
        public class Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y) => (X, Y) = (x, y);

            public void Deconstruct(out int x, out int y) =>
                (x, y) = (X, Y);
        }

        public enum Quadrant
        {
            Unknown,
            Origin,
            One,
            Two,
            Three,
            Four,
            OnBorder
        }

        public static Quadrant GetQuadrant(Point point) =>
            point switch
            {
                (0, 0) => Quadrant.Origin,
                var (x, y) when x > 0 && y > 0 => Quadrant.One,
                var (x, y) when x < 0 && y > 0 => Quadrant.Two,
                var (x, y) when x < 0 && y < 0 => Quadrant.Three,
                var (x, y) when x > 0 && y < 0 => Quadrant.Four,
                var (_, _) => Quadrant.OnBorder,
                _ => Quadrant.Unknown
            };

    }
}
