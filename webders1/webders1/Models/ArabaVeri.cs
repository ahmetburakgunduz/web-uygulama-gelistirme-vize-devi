using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webders1.Models
{
    public class ArabaVeri
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public int MotorGucu { get; set; }
    
   

    public static List<ArabaVeri> VeriListe = new List<ArabaVeri>
    {
        new ArabaVeri
        {
            Id = 1,
            Marka = "HONDA",
            Model = "CIVIC",
            Yil = 2008,
            MotorGucu = 120,

        },

         new ArabaVeri
        {
            Id = 2,
            Marka = "OPEL",
            Model = "CORSA",
            Yil = 2015,
            MotorGucu = 140,

        },
         
        new ArabaVeri
        {
            Id = 3,
            Marka = "RENAULT",
            Model = "CLİO",
            Yil = 2017,
            MotorGucu = 95,

        },
     };

   }
}