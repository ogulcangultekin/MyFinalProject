using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün ekelendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime="Sistem bakımda";
        internal static string ProductsListed="Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        internal static string ProductNameAlreadyExists="Bu isimde zaten ürün var";
        internal static string CategoryLimitExceded="Kategori limiti aşıldı";
        internal static string AuthorizationDenied ="Yetkiniz bulunmamaktadır.";
        internal static string UserRegistered="Kayıt olundu";
        internal static string UserNotFound="Kullanıcı bulunamadı.";
        internal static string PasswordError="Şifre hatalı";
        internal static string SuccessfulLogin="Giriş başarılı";
        internal static string UserAlreadyExists="Kullanıcı zaten mevcut.";
        internal static string AccessTokenCreated = "Token oluşturuldu";
    }
}
