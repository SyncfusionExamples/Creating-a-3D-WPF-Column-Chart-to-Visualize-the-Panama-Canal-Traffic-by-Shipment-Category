namespace PanamaCanalTransit
{
    public class TransitModel
    {
        public string? MarketSegments { get; set; }
        public double NumberOfCrossing2022 {  get; set; }
        public double NumberOfCrossing2023 { get; set; }

        public TransitModel(string marketSegments,double numberOfCrossing2023,double numberOfCrossing2022)
        {
            MarketSegments = marketSegments;
            NumberOfCrossing2023 = numberOfCrossing2023;
            NumberOfCrossing2022 =numberOfCrossing2022;
        }
    }
}
