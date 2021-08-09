
namespace Dojodachi.Models
{
  public class Dachi {
    public int Happiness {get; set;}
    public int Fullness {get; set;}
    public int Energy {get; set;}
    public int Meals {get; set;}

    public int Feed()
    {
      return Fullness;
    }
    public int Play()
    {
      return Happiness;
    }
    public int Work()
    {
      return Energy;
    }
    public int Sleep()
    {
      return Energy;
    }
  }
}