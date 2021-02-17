using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarDeleted = "Araba kaldırıldı";
        public static string GetAllCar = "Arabalar Listelendi";
        public static string GetCarByBrandId = "Arabalar Markalara göre listelendi";
        public static string GetCarsByColorId = "Arabalar renklere göre listelendi";
        public static string GetCarDetails = "Araba özellikleri listelendi.";
        public static string GetCarById = "Araba gösteriliyor";
        public static string GetCarByIdInvalid = "Araba özellikleri listelenemedi.";
        public static string CarNameInvalid = "Araba ismi geçersiz en az 2 karakter olmalı!";

        public static string RentalAdded = "Araç kiralandı";
        public static string RentalAddInvalid = "Araç kirada";
        public static string RentalDeleted = "Araç silindi";
        public static string RentalUpdated = "Araç güncellendi";

    }
}
