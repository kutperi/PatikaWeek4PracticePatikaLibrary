

using PatikaWeek4PracticePatikaKütüphanesi;

// Creating a new object using default constructor

Book book1 = new Book(); 
book1.bookName = "Bilal'in Sancıları";
book1.authorName = "Bilal";
book1.authorSurname = "Bilin";
book1.pageCount = 1;
book1.publisher = "Patika";

book1.BookInfo();

Console.WriteLine("---------------------------------------------------------");

// Creating a new object using constructor that takes parameters

Book book2 = new Book("Kalecinin Penaltı Anındaki Endişesi", "Peter", "Handke", 112, "Ayrıntı");

book2.BookInfo();

Console.WriteLine("---------------------------------------------------------");

Book book3 = new Book("Türklük Sözleşmesi", "Barış", "Ünlü", 380, "Dipnot");

book3.BookInfo();



/*

    Class: Belirli bir türdeki nesnelerin özelliklerini ve davranışlarını belirleyen bir şablondur. Verileri(Properties ve fields) ve bu verilere yönelik işlemleri(methods) barındırır.
    
    Property: Sınıf içerisindeki field'lara erişimi kontrol eden ve sınıfın dışına belirli bir düzeyde güvenli erişim sağlayan yapılar olarak tanımlanabilir.
    
    New: OOP'de bir sınıfın örneğini yani nesnesini(object) oluşturmak için kullanılan anahtar sözcüktür.
    
    Constructor: Sınıf yapılarının nesne olarak tanımlanmasında kurucu olan, sınıf ismiyle aynı isime sahip olan, geriye değer döndürmeyen bir metod türüdür.
 
 
 */