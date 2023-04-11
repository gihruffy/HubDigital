using System.Globalization;

namespace HubDigital.Dominio.Helpers
{
    public class HubDigitalException : Exception
    {
        public HubDigitalException() : base() { }

        public HubDigitalException(string message) : base(message) { }

        public HubDigitalException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
