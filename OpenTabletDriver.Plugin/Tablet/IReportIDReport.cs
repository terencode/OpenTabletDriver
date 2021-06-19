namespace OpenTabletDriver.Plugin.Tablet
{
    public interface IReportIDReport : IDeviceReport
    {
        uint ReportID { set; get; }
    }
}