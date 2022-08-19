using Buyfilet.Common.Enums;

namespace GoogleForms.Common
{
    public interface IResponse
    {
        string Message { get; set; }
        ResponseType ResponseType { get; set; }
    }
}
