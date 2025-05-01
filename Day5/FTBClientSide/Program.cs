namespace FTBClientSide
{
    public enum NICType
    {
        Ethernet,
        TokenRing
    }

    public class NIC
    {

        private static NIC _instance;

        private NIC(string manufacturer, string macAddress, NICType type)
        {
            Manufacturer = manufacturer;
            MACAddress = macAddress;
            Type = type;
        }

        public string Manufacturer { get; }
        public string MACAddress { get; }
        public NICType Type { get; }

        public static NIC GetInstance(string manufacturer, string macAddress, NICType type)
        {
            if (_instance == null)
            {
                _instance = new NIC(manufacturer, macAddress, type);
            }
            return _instance;
        }
        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}\nMAC Address: {MACAddress}\nType: {Type}";
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NIC nic = NIC.GetInstance("Intel", "00-14-22-01-23-45", NICType.Ethernet);
            Console.WriteLine(nic);


            NIC anotherNic = NIC.GetInstance("AMD", "00-25-96-FF-EE-DD", NICType.TokenRing);
            Console.WriteLine(anotherNic);
        }
    }
}
