# Creating-a-3D-WPF-Column-Chart-to-Visualize-the-Panama-Canal-Traffic-by-Shipment-Category
This sample demonstrates how to creating a visually engaging 3D column chart using WPF. The chart aims to provide insights into the traffic flow through the Panama Canal, with data categorized based on shipment types. 

## Customizing the Chart Appearance
The appearence of the Column3D chart can be customized to improve the visual quality, we can customize the appearence using the [PerspectiveAngle](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.SfChart3D.html#Syncfusion_UI_Xaml_Charts_SfChart3D_PerspectiveAngle), [Rotation](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.SfChart3D.html#Syncfusion_UI_Xaml_Charts_SfChart3D_Rotation), [EnableRotation](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.SfChart3D.html#Syncfusion_UI_Xaml_Charts_SfChart3D_EnableRotation), [Depth](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.SfChart3D.html#Syncfusion_UI_Xaml_Charts_SfChart3D_Depth) of the chart, [Interior](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_Interior) and [SegmentSpacing](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ColumnSeries3D.html#Syncfusion_UI_Xaml_Charts_ColumnSeries3D_SegmentSpacing) of the column series. 

## Adding Data labels in Column chart

By using the [ChartAdornmentsInfo3D](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartAdornmentInfo3D.html) of the ColumnSeries3D  class, we can customized the data label of segments on Column chart using [ShowLabel](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartAdornmentInfoBase.html#Syncfusion_UI_Xaml_Charts_ChartAdornmentInfoBase_ShowLabel), [LabelPosition](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartAdornmentInfoBase.html#Syncfusion_UI_Xaml_Charts_ChartAdornmentInfoBase_LabelPosition), [FontSize](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartAdornmentInfoBase.html#Syncfusion_UI_Xaml_Charts_ChartAdornmentInfoBase_FontSize) and [Margin](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartAdornmentInfoBase.html#Syncfusion_UI_Xaml_Charts_ChartAdornmentInfoBase_Margin)

By implementing these customizations, we can transform the  3D column chart into a visually striking representation of Panama Canal traffic, enriched with insightful details and clarity.

 we’ll get an output mentioned below,

![image](https://github.com/SyncfusionExamples/Creating-a-3D-WPF-Column-Chart-to-Visualize-the-Panama-Canal-Traffic-by-Shipment-Category/assets/113962276/0ce2b782-a7d9-41e3-b0ec-8c27e50e2eed)

## Troubleshooting

### Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For a step-by-step procedure, refer to the [Panama Canal traffic]() blog post.

