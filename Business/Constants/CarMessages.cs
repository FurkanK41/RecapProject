using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    // hoca 1 tane nesneye yazılar verdiği için 1 tane messages class ı oluşturdu ben 1 den fazla class oluşturacam ileride duruma göre hoca gibi yapabilirim.
    public class CarMessages : IMessages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba İsmi geçersiz";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarDeleted = "Araba silindi";

    }
}
