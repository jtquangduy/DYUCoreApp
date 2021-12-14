using DYUCoreApp.Data.Enums;

namespace DYUCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}