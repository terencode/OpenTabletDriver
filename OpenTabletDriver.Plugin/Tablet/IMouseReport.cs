using System.Numerics;

namespace OpenTabletDriver.Plugin.Tablet
{
    public interface IMouseReport : IAbsolutePositionReport, IReportIDReport
    {
        bool[] MouseButtons { set; get; }
        Vector2 Scroll { set; get; }
    }
}