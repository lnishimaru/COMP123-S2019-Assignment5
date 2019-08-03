using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarComputers
{
    public enum ComputersFields
    {
        PRODUCT_ID,
        COST,
        MANUFACTURER,
        MODEL,
        RAM_TYPE,
        RAM_SIZE,
        DISPLAY_TYPE,
        SCREEN_SIZE,
        RESOLUTION,
        CPU_CLASS,
        CPU_BRAND,
        CPU_TYPE,
        CPU_SPEED,
        CPU_NUMBER,
        CONDITION,
        OS,
        PLATFORM,
        HDD_SIZE,
        HDD_SPEED,
        GPU_TYPE,
        OPTICAL_DRIVE,
        AUDIO_TYPE,
        LAN,
        WIFI,
        WIDTH,
        HEIGHT,
        DEPTH,
        WEIGHT,
        POWER,
        WEBCAM,
        NUMBER_OF_FIELDS
    }
    /// <summary>
    /// Temporary class to storage data from the products between forms and actions
    /// </summary>
    public class Computers
    {
        public int ProductID { get; set; }
        public double Cost { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string RAMType { get; set; }
        public string RAMSize { get; set; }
        public string DisplayType { get; set; }
        public string ScreenSize { get; set; }
        public string Resolution { get; set; }
        public string CPUClass { get; set; }
        public string CPUBrand { get; set; }
        public string CPUType { get; set; }
        public string CPUSpeed { get; set; }
        public string CPUNumber { get; set; }
        public string Condition { get; set; }
        public string OS { get; set; }
        public string Platform { get; set; }
        public string HDDSize { get; set; }
        public string HDDSpeed { get; set; }
        public string GPUType { get; set; }
        public string OpticalDrive { get; set; }
        public string AudioYTpe { get; set; }
        public string LAN { get; set; }
        public string WIFI { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Depth { get; set; }
        public string Weight { get; set; }
        public string MouseType { get; set; }
        public string Power { get; set; }
        public string WebCam { get; set; }
    }
}
