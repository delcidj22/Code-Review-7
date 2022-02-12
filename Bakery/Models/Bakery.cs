using System.Collections.Generic;

namespace Bakery.Modles //Name needs to change depending on project name
{
  public class Bakery
  {
    public int NumberOfLoaves {get; set; }
    public int CostOfLoaves {get; set; }
    public Bread(int numberOfLoaves, int costOfLoaves = 0)
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


}