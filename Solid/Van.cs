namespace Solid {
  class Van: IConsume {

    public Van( int consumption ) {
      Consumption = consumption;
    }

    //public string Consume( int mileages ) {
    //  return string.Format( "As Van I consumed {0} litres", mileages * Consumption );
    //}

    private int Consumption { get; set; }
    public string FuelConsumption( int mileages ) {
      return string.Format( "As Van I consumed {0} litres", mileages * Consumption );
    }
  }
}