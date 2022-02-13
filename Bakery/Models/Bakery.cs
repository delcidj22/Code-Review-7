namespace Bakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves { get; set; }
    public int CostOfLoaves { get; set; }
    public Bread(int numberOfLoaves, int costOfLoaves = 0 )
    {
      NumberOfLoaves = numberOfLoaves;
      CostOfLoaves = costOfLoaves;
    }

    public int SetPrice()
    {
      if (NumberOfLoaves >2)
      {
        CostOfLoaves = ((NumberOfLoaves / 3) * 10 )+((NumberOfLoaves % 3)*5);
        return CostOfLoaves;
      }
        CostOfLoaves = NumberOfLoaves * 5;
        return CostOfLoaves;
    }
  }

  public class Pastry
  {
    public int NumberOfPastries {get; set; }
    public int CostOfPastries {get; set; }
    public Pastry(int numberOfPastries, int costOfPastries = 0)
    {
      NumberOfPastries = numberOfPastries;
      CostOfPastries = numberOfPastries;
    }
    public int SetPrice()
    {
      if(NumberOfPastries >2)
      {
        CostOfPastries = ((NumberOfPastries / 3) * 5) + ((NumberOfPastries % 3)*2);
        return CostOfPastries;
      }
        CostOfPastries = NumberOfPastries *2;
        return CostOfPastries;
    }
  }
  public class OrderTotal
  {
    public static int CalculatedTotal(int CostOfLoaves, int CostOfPastries)
    {
      int Total = CostOfLoaves + CostOfPastries;
      return Total;
    }
  }
}