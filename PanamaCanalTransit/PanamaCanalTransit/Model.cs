namespace PanamaCanalTransit
{
    public class TransitModel
    {
        public string? Category { get; set; }
        public double NumberOfCrossing2022 {  get; set; }
        public double NumberOfCrossing2023 { get; set; }

        public TransitModel(string category,double numberOfCrossing2023,double numberOfCrossing2022)
        {
            Category = category;
            NumberOfCrossing2023 = numberOfCrossing2023;
            NumberOfCrossing2022 =numberOfCrossing2022;
        }
    }
}
