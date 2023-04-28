namespace SpecFlowProject.Models;

public class OrderData
{
    public int Drinks { get; set; }
    public int Starters { get; set; }
    public int Mains { get; set; }
    public TimeSpan Time { get; set; }
}