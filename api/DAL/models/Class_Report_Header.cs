using System;

namespace api.DAL.models
{
    public class Class_Report_Header
    {
         public int Id { get; set; }
         public int procedure_id { get; set; }
        public string hospital_name { get; set; }
        public string hospital_image { get; set; }
        public string hospital_unit { get; set; }
        public string hospital_dept { get; set; }
        public string hospital_city { get; set; }
        public string hospital_number { get; set; }
        public string patient_name { get; set; }
        public string physician { get; set; }
        public string clinical_unit { get; set; }
        public string report_header { get; set; }
        public string diagnosis { get; set; }
        public string operation { get; set; }
        public string operation_date { get; set; }
        public string surgeon { get; set; }
        public string assistant { get; set; }
        public string anaesthesiologist { get; set; }
        public string perfusionist { get; set; }
        public string Comment_1 { get; set; }
        public string Comment_2 { get; set; }
        public string Comment_3 { get; set; }
    }
}