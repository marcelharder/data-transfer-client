using System;

namespace api.DAL.models
{
    public class Class_Valve_Code
    {
        public virtual int Id { get; set; }
        public int No { get; set; }
        public string Description { get; set; }
        public string Vendor_code { get; set; }
        public string Product_code { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public DateTime? Manufac_date { get; set; }
        public DateTime? Expiry_date { get; set; }
        public string Serial_no { get; set; }
        public string Model_code { get; set; }
        public string Size { get; set; }
        public string Implant_position { get; set; }
        public short? Procedure_id { get; set; }
        public short? implanted { get; set; }
        public short? Hospital_code { get; set; }
        public DateTime? Implant_date { get; set; }

    }
}