using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class BrandMessages : IMessages
    {
        public static string BrandAdded = "Araba eklendi";
        public static string BrandNameInvalid = "Araba İsmi geçersiz";
        public static string BrandsListed = "Arabalar listelendi";
        public static string BrandDeleted = "Araba silindi";
    }
}
