using System.Globalization;

namespace SpecFlowProject.Extensions;

public static class NumberExtensions
{
    public static decimal ToDecimalRound(this decimal value)
    {
        return Math.Round(value, 2, MidpointRounding.AwayFromZero);
    }

    public static decimal ToDecimalRound(this double value)
    {
        return Math.Round(Convert.ToDecimal(value), 2, MidpointRounding.AwayFromZero);
    }

    public static decimal ToDecimalRound(this string value)
    {
        decimal d = decimal.Parse(value, CultureInfo.InvariantCulture);
        return Math.Round(d, 2, MidpointRounding.AwayFromZero);
    }

    public static decimal ToDecimal(this object obj)
    {
        IConvertible? convert = obj as IConvertible;
        return convert?.ToDecimal(null) ?? 0m;
    }
}