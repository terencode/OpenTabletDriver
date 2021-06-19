namespace OpenTabletDriver.Plugin.Tablet
{
    public interface ITabletReport : IAbsolutePositionReport, IReportIDReport
    {
        uint Pressure { set; get; }
        bool[] PenButtons { set; get; }
    }
}
