using System;

namespace ApplicationDomain.Info
{
    public static class ProductInfo
    {
        static ProductInfo()
        {
            Name = "UL-Paisa";
            Version = "1.0";
            Copyright = DateTime.Now;
        }
        public static string Name { get; set; }
        public static string Version { get; set; }
        public static DateTime Copyright { get; set; }
    }
}
