using System;
using System.IO;
using System.Web;

namespace MVCBlogProject.COMMON.Tools
{
    public class ImageUploader
    {
        public static string UploadSingleImage(string serverPath, HttpPostedFileBase file)
        {
            if (file != null) //Gelen dosya boş mu diye kontrol ediyoruz
            {
                serverPath = serverPath.Replace("~", string.Empty); //Gelen dosya yolunda bulunan ~ karakterini kaldırıyoruz.
                string[] fileArray = file.FileName.Split('.'); //Gelen dosya adında noktadan öncesini ve sonrasını dizi içerisine alıyoruz. Böyle uzantısını elde ediyoruz.
                string extension = fileArray[fileArray.Length - 1].ToLower(); //Alınan dosya uzantısını tamamen büyük harfe çeviriyoruz.
                string fileName = Guid.NewGuid() + "." + extension; //Dosya adı için bir Guid oluşturup sonuna dosya uzantısını iliştiriyoruz.

                if (extension == "jpg" || extension == "png" || extension == "gif" || extension == "jpeg") //Dosya uzantı kontrolü yapıyoruz.
                {
                    if (File.Exists(HttpContext.Current.Server.MapPath(serverPath + fileName))) //Aynı isimde bir dosya var mı kontrolü yapıyoruz.
                    {
                        return "Dosya mevcut!";
                    }
                    else
                    {
                        //Gelen isimde bir dosya yoksa sunucu tarafına dosyayı kaydediyoruz.
                        var filePath = HttpContext.Current.Server.MapPath(serverPath + fileName);
                        file.SaveAs(filePath);
                        return serverPath + fileName;
                    }
                }
                else
                {
                    return "Dosya tipi yanlış!";
                }
            }
            else
            {
                return "noimage.jpg";
            }
        }
    }
}
