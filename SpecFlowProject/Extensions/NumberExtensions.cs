using System.Globalization;

namespace SpecFlowProject.Extensions;

public static class NumberExtensions
{
    public static double ToDoubleRound(this double value)
    {
        return Math.Round(value, 2, MidpointRounding.AwayFromZero);
    }
    
    public static double ToDoubleRound(this string value)
    {
        double d = double.Parse(value, CultureInfo.InvariantCulture);
        return Math.Round(d, 2, MidpointRounding.AwayFromZero);
    }

    public static double ToDouble(this object obj)
    {
        IConvertible convert = obj as IConvertible;
        return convert?.ToDouble(null) ?? 0d;
    }
}