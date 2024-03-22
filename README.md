# Creating-a-3D-WPF-Column-Chart-to-Visualize-the-Panama-Canal-Traffic-by-Shipment-Category
This sample demonstrates how to creating a visually engaging 3D column chart using WPF. The chart aims to provide insights into the traffic flow through the Panama Canal, with data categorized based on shipment types. 

# Customizing the Chart Appearance
To  refine the visual aesthetics of our chart, we have the opportunity to enhance its elements, such as including a chart title ,positioning of chart, enabling a legend, and customizing various aspects like series, axis, and chart elements.

## Chart Positioning
Enhance the  3D column chart's layout with precise spacing and rotation using Syncfusion's SfChart3D attributes. Achieve a clear visual comparison of series with side-by-side placement, ensuring an immersive experience for analyzing Panama Canal traffic trends.

```XAML
<chart:SfChart3D Margin=" -25,0,5,5" 
                 Depth="200" 
                 EnableRotation="True"
                 PerspectiveAngle="50"
                 Rotation="29"
                 SideBySideSeriesPlacement="True" 
                 Background="Transparent">
</ chart:SfChart3D>

```

## Chart axis customization
Optimize the chart's axis appearance for a more comprehensible view. Customize the axis settings based on your preferences and requirements to achieve a polished look.

```XAML
<chart:SfChart3D.PrimaryAxis>
    <chart:CategoryAxis3D TickLineSize="0" ShowGridLines="False">
        <chart:CategoryAxis3D.LabelStyle>
            <chart:LabelStyle FontSize="12.8"/>
        </chart:CategoryAxis3D.LabelStyle>
    </chart:CategoryAxis3D>
</chart:SfChart3D.PrimaryAxis>

<chart:SfChart3D.SecondaryAxis >
    <chart:NumericalAxis3D TickLineSize="0" Interval="500" Maximum="3500">
        <chart:NumericalAxis3D.LabelStyle>
            <chart:LabelStyle FontSize="12.9"/>
        </chart:NumericalAxis3D.LabelStyle>
    </chart:NumericalAxis3D>
</chart:SfChart3D.SecondaryAxis>

```

## Chart Title customization
Adding a title to the chart can help users understand the data being visualized. Here’s how you can customize the chart title.

```XAML
<chart:SfChart3D.Header>
    <Grid Margin="-100,0,0,3" x:Name="header" Grid.Column="0" HorizontalAlignment="Left">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="70"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>

        <ContentPresenter  Grid.Column="0">
            <ContentPresenter.Content>
                <Image Source="Resources\ship.png"></Image>
            </ContentPresenter.Content>
        </ContentPresenter>

        <Grid Grid.Column="1" >
            <Grid.RowDefinitions>
                <RowDefinition></RowDefinition>
                <RowDefinition></RowDefinition>
            </Grid.RowDefinitions>
            <StackPanel Grid.Row="0"   Margin="5,0,0,0" HorizontalAlignment="Left" Orientation="Vertical">
                <Label Content="The Panama Canal Traffic by Shipment Category in 2022-2023" FontSize="18"  FontFamily="AntaRegular" FontWeight="Bold"/>
                <Label Content="The quantity of shipments passing through the Panama Canal varies across different categories of transit." FontSize="14"  Margin="0,2,0,0" FontFamily="AntaRegular"/>
            </StackPanel>

            <StackPanel Grid.Row="1"  Orientation="Horizontal" Margin="10,5,0,5">
                <Rectangle Height="12" Width="30" RadiusX="5" RadiusY="5" Fill="#96D759" />
                <TextBlock Text="2022" FontSize="15" Margin="7,0,0,0" />
                <Rectangle Height="12" Width="30" RadiusX="5" RadiusY="5" Fill="#775DD0" Margin="7,0,0,0" />
                <TextBlock Text="2023" Margin="7,0,0,0" FontSize="15"/>
            </StackPanel>
        </Grid>
    </Grid>
</chart:SfChart3D.Header>

```


## Customizing the 3D Column appearance
Elevate the series' visual appeal by assigning distinct interior colors to each series, configuring segment spacing for better separation, and initializing adornments for additional series details.

```XAML
<chart:ColumnSeries3D ItemsSource="{Binding TransitData}"
                      XBindingPath="MarketSegemnts"
                      YBindingPath="NumberOfCrossing2022"
                      Interior="#96D759"
                      SegmentSpacing="0.3"
                      Label="2022">
    <chart:ColumnSeries3D.AdornmentsInfo>
        <chart:ChartAdornmentInfo3D ShowLabel="True" FontSize="7" Margin="0,0.1,0,0" LabelPosition="Inner"/>
    </chart:ColumnSeries3D.AdornmentsInfo>
</chart:ColumnSeries3D>

<chart:ColumnSeries3D ItemsSource="{Binding TransitData}"
                       XBindingPath="MarketSegemnts"
                       YBindingPath="NumberOfCrossing2023"
                      Interior="#775DD0"
                      SegmentSpacing="0.3"
                      Label="2023">
    <chart:ColumnSeries3D.AdornmentsInfo>
        <chart:ChartAdornmentInfo3D ShowLabel="True" FontSize="7" Margin="0,0.1,0,0" LabelPosition="Inner"/>
    </chart:ColumnSeries3D.AdornmentsInfo>
</chart:ColumnSeries3D>


```


By implementing these customizations, we can transform the  3D column chart into a visually striking representation of Panama Canal traffic, enriched with insightful details and clarity.

After executing the previous code examples, we’ll get an output like in the following image.


![image](https://github.com/SyncfusionExamples/Creating-a-3D-WPF-Column-Chart-to-Visualize-the-Panama-Canal-Traffic-by-Shipment-Category/assets/113962276/0ce2b782-a7d9-41e3-b0ec-8c27e50e2eed)


Path too long exception
If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For a step-by-step procedure, refer to the [Panama Canal traffic]() blog post.

