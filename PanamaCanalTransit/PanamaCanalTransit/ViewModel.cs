using System.Collections.ObjectModel;

namespace PanamaCanalTransit
{
    public class ViewModel
    {
        public ObservableCollection<TransitModel> TransitData {  get; set; }
        public ViewModel() 
        {
            TransitData = new ObservableCollection<TransitModel>();
            TransitData.Add(new TransitModel("Dry Bulk", 2649, 2910));
            TransitData.Add(new TransitModel("Container", 2787, 2822));
            TransitData.Add(new TransitModel("Chemical Tankers", 2196, 2332));
            TransitData.Add(new TransitModel("LPG", 1757, 1501));
            TransitData.Add(new TransitModel("Vehicle Carriers", 813, 746));
            TransitData.Add(new TransitModel("General Cargo", 519, 645));
            TransitData.Add(new TransitModel("Crude Tankers", 499, 607));
            TransitData.Add(new TransitModel("Refrigerated", 546, 604));
            TransitData.Add(new TransitModel("LNG", 326 ,374));
            TransitData.Add(new TransitModel("Passengers", 240, 127));
            TransitData.Add(new TransitModel("Others", 306, 335));
        }
    }
}
