using System.Drawing;

namespace restaurantAuto
{
    class colors
    {
        public static Color green = System.Drawing.ColorTranslator.FromHtml("#87CEFA");
        public static Color lightGreen = System.Drawing.ColorTranslator.FromHtml("#66ffa6");
        public static Color darkGreen = System.Drawing.ColorTranslator.FromHtml("#4682B4");

        public static Color red = System.Drawing.ColorTranslator.FromHtml("#E53935");
        public static Color lightRed = System.Drawing.ColorTranslator.FromHtml("#ff6f60");
        public static Color darkRed = System.Drawing.ColorTranslator.FromHtml("#ab000d");

        public static Color pink = System.Drawing.ColorTranslator.FromHtml("#ff4081");
        public static Color lightPink = System.Drawing.ColorTranslator.FromHtml("#ff79b0");
        public static Color darkPink = System.Drawing.ColorTranslator.FromHtml("#c60055");
        public static Region region(int Width, int Height)
        {
            return System.Drawing.Region.FromHrgn(roundCorners.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
    }
}
