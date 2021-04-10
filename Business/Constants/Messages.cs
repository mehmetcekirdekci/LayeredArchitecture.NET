using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Sifre hatalı";

        public static string SuccessfulLogin = "Sisteme giris basarili";

        public static string UserAlreadyExist = "Bu kulllanıcı zaten mevcut";

        public static string UserRegeistered = "Kullanıcı başarıyla kaydedildi";

        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu";
    }
}
