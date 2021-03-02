using System;

namespace api.DAL.models
{
    public class Class_Valve
    {
        public virtual int page_to_open { get; set; }
        public int Id { get; set; }
        public int PROCEDURE_ID { get; set; }
        public string AORTIC_IMPLANT { get; set; }
        public string AORTIC_EXPLANT { get; set; }
        public string AORTIC_SIZE { get; set; }
        public string AORTIC_TYPE { get; set; }
        public string AORTIC_SIZE_EXP { get; set; }
        public Nullable<int> AORTIC_TYPE_EXP { get; set; }
        public string MITRAL_IMPLANT { get; set; }
        public string MITRAL_EXPLANT { get; set; }
        public string MITRAL_SIZE { get; set; }
        public string MITRAL_TYPE { get; set; }
        public string MITRAL_SIZE_EXP { get; set; }
        public Nullable<int> MITRAL_TYPE_EXP { get; set; }
        public string TRICUSPID_IMPLANT { get; set; }
        public string TRICUSPID_EXPLANT { get; set; }
        public string TRICUSPID_SIZE { get; set; }
        public string TRICUSPID_TYPE { get; set; }
        public string TRICUSPID_SIZE_EXP { get; set; }
        public Nullable<int> TRICUSPID_TYPE_EXP { get; set; }
        public string PULMONIC_IMPLANT { get; set; }
        public string PULMONIC_EXPLANT { get; set; }
        public string PULMONIC_SIZE { get; set; }
        public string PULMONIC_TYPE { get; set; }
        public string PULMONIC_SIZE_EXP { get; set; }
        public Nullable<int> PULMONIC_TYPE_EXP { get; set; }
        public string AORTIC_PROCEDURE { get; set; }
        public string MITRAL_PROCEDURE { get; set; }
        public Nullable<int> TRICUSPID_PROCEDURE { get; set; }
        public Nullable<int> PULMONIC_PROCEDURE { get; set; }
        public string AORTIC_AETIOLOGY { get; set; }
        public string MITRAL_AETIOLOGY { get; set; }
        public string TRICUSPID_AETIOLOGY { get; set; }
        public string PULMONIC_AETIOLOGY { get; set; }
        public string AORTIC_MODEL { get; set; }
        public string AORTIC_MODEL_EXP { get; set; }
        public string MITRAL_MODEL { get; set; }
        public string MITRAL_MODEL_EXP { get; set; }
        public string TRICUSPID_MODEL { get; set; }
        public string TRICUSPID_MODEL_EXP { get; set; }
        public string PULMONIC_MODEL { get; set; }
        public string PULMONIC_MODEL_EXP { get; set; }
        public string AORTIC_SERIAL_IMP { get; set; }
        public string AORTIC_SERIAL_EXP { get; set; }
        public string MITRAL_SERIAL_IMP { get; set; }
        public string MITRAL_SERIAL_EXP { get; set; }
        public string TRICUSPID_SERIAL_IMP { get; set; }
        public string TRICUSPID_SERIAL_EXP { get; set; }
        public string MITRAL_RING_USED { get; set; }
        public string TRICUSPID_RING_USED { get; set; }
        public string MITRAL_REPAIR_TYPE { get; set; }
        public string TRICUSPID_REPAIR_TYPE { get; set; }
        public string PULMONIC_SERIAL_EXP { get; set; }
        public string Memo { get; set; }
        public string Combined { get; set; }
    }
}