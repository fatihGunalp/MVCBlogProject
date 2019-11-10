# MVCBlogProject
YMS3423 nolu grubun blog projesi

Proje 7 katmandan oluşmaktadır. Katmanların detayları aşağıdaki gibidir;
 
# CORE

Referanslar=> EntityFramework (Nuget)

Bu katman diğer katmanlarda tanımlı olan bütün classın çekirdek sınıflarını barındırır.
  -Entity
    -IEntity
    -CoreEntity
    -Enum
    
  -Map
    -CoreMap
    
  -Service
    --ICoreService

# MODEL

 Referanslar=> EntityFramework (Nuget) MVCBlogProject.CORE
 
 proje içerisindeki varlıklar (Entity) bu katman içerisinde saklanmaktadır.
 
    -Entities
      -Article
      -Category
      -Comment
      -Tag
      -Todo
      -User
     -Enums
      -Role
      
 # DAL
 
 Referanslar=> EntityFramework (Nuget) => MVCBlogProject.CORE => MVCBlogProject.MODEL
 
 veritabanı ile bağlantı kuracan katman. İçerisinde Context nesnesini barındırmaktadır.
 
      -Model
        -BlogContext
        
  # MAP
 
 Referanslar=> EntityFramework (Nuget) => MVCBlogProject.CORE => MVCBlogProject.MODEL => MVCBlogProject.DAL
 
 projede oluşturulan varlıkların veritabanındaki ilişkilendirilmesi bu katman vasıtası ile gerçekleştirilmektedir.
 
      -Maps
       -ArticleMap
       -CategoryMap
       -CommentMap
       -TagMap
       -TodoMap
       -UserMap
       
   # MVCBlogProject.UI
   
   Referanslar=> EntityFramework (Nuget) => MVCBlogProject.CORE => MVCBlogProject.MODEL => MVCBlogProject.DAL
   
   projenin user interface (UI) katmanları olarak açıldı.
   
   
  
  # COMMON
  
  katmanlarda ortak olarak kullanılacak nesneler bu katman içerisinde tanımlandı. Bu sayede her bir katmanda kullanmak istediğimiz mail gönderimi, görsel ekleme gibi işlemler bu katmandan dağıtılıyor.
  
      -HtmlUtility
      -ImageUploader
      -MailSender
