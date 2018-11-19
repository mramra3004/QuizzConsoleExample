using ProductManagement.ConsoleApplication.Data.Enum;

namespace ProductManagement.ConsoleApplication.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}