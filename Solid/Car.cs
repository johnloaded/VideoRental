namespace Solid {
  public class Car: IConsume {
    public Car( int consumption ) {
      Consumption = consumption;
    }

    //public string Consume( int mileages ) {
    //  return string.Format( "As car I consumed {0} litres", mileages * Consumption );
    //}

    private int Consumption { get; set; }

    public string FuelConsumption( int mileages ) {
      return string.Format( "As car I consumed {0} litres", mileages * Consumption );
    }
  }
}