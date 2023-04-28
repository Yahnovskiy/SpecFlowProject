namespace SpecFlowProject.Extensions;

public static class TimeExtensions
{
    public static TimeSpan ToTimeSpan(this object value)
    {
        if (!TimeSpan.TryParse(value.ToString(), out var time))
            time = default;
        return time;
    }
}