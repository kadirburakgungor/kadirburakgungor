//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Onkolab.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prescription
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int Boy { get; set; }
        public int Kg { get; set; }
        public int ProtokolId { get; set; }
        public int SubDiagnosisId { get; set; }
        public int MainDiagnosisId { get; set; }
        public double Bsa { get; set; }
        public int TeslimEdilecekBirimId { get; set; }
        public bool Silindi { get; set; }
    }
}