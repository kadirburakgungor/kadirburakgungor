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
    
    public partial class Medicines
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EtkenMaddeId { get; set; }
        public int BrandId { get; set; }
        public string Barcode { get; set; }
        public string Gtin { get; set; }
        public double Mg { get; set; }
        public double Ml { get; set; }
        public int UnitId { get; set; }
        public double Ozkutle { get; set; }
        public int CozucuTuruId { get; set; }
        public double CozucuMıktarı { get; set; }
        public int CozmeHızıId { get; set; }
        public double mgveyau1 { get; set; }
        public string TasiyiciSolisyon { get; set; }
        public int KaristirmaHiziId { get; set; }
        public double BirimDoz { get; set; }
        public double KaristirmaSuresi { get; set; }
        public int SonKullanımSuresi { get; set; }
        public string SeyreltmeSolisyonu { get; set; }
        public int EnjeksiyonHiziId { get; set; }
        public string FormTipi { get; set; }
    }
}
