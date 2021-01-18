using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fonksiyonlar iki farklı yolla çağrıldığı yere değer döndürür.
            .Birincisi return anahtar kelimesiyle,
            .İkincisi ise parametre ile değer döndürme. Parametre ile değer döndürmek için out veya ref kullanırız. */

            /* Out Anahtar Kelimesi--
             * Parametre ile sadece değer döndürmek için parametre tanımında tip isminden önce
            out deyimi kullanılır. Bu parametreye metot içerisinden dışarıya değer döndürmesi için mutlaka bir değer atanmalıdır.
            Aşağıda tanımlanan "kare" metodu Main içerisinde çağrıldığında a parametresi sadece değer almakta ve kupu parametresi 
            ise dışarıya sadece değer döndürmektedir. Out ile tanımlanan parametreye çağrıldığı yerde karşılık gelen değişkenin önünde mutlaka
            out kelimesi kullanılmalıdır. Sabit bir değer kullanılamaz. Aşağıda kare fonsiyonu çağrıldığında
            x verilen 5 değerini alırken c ise "out c" şeklinde çağrılarak fonsiyon içindeki "out int kupu" ile tanımlanmış 
            "kupu" değişkeninin değerini alır.*/

            /* Ref Anahtar Kelmesi--
            .Parametre ile sadece değer döndürmek için out kelimesini kullandık.(tek taraflı çalışır -> değer döndürür)
            .Parametreye ***hem değer göndermek *** hem de parametrenin son değerini geri döndürmek için ref kelimesi kullanılır.
            Bunun anlamı metoda değişkenin değeri yerine adresinin gönderileceğidir.
            (çift taraflı çalışır -> hem metot içine değer gönderir hem de metotdan dışarı değer dönderir)
            .Ref ile belirtilen bir parametreye metot içinde dışarıya değer döndürmesi için bir değer atamaya gerek yoktur.
            Bu durumda önceki değeri korunmuş olur.*/

            // out kullanımı--
            int x = 5, c;
            Console.WriteLine("Sayı :" + x);
            Console.WriteLine("Kare :" + kare(x, out c)); // metot return ile karesini döndürdüğü için çağrıldığı yerde karesini döndürdü
            Console.WriteLine("Küp : " + c); //c "out c" ile metot içinde tanımlanan kupu değerini aldı

            Console.WriteLine(" ");

            //ref kullanımı--
            /* metot içerisinde ref ile tanımlanan parametreye karşılık çağrılma yerinde önünde ref kelimesi olan bir
            değişken kullanılmalıdır. Sabit bir değer kullanılamaz. */

            int s1 = 27, s2 = 65;
            Console.WriteLine("Öncesi s1 ={0} s2 = {1}", s1, s2);
            
            degistir(ref s1, ref s2); // aşağıda tanımlanan degistir metodu çağrılarak s1 ve s2 değerleri değiştirildi.
            Console.WriteLine("Sonrası s1 = {0} s2 = {1}", s1 , s2);
        }


        //out örn. metodu
        static int kare(int a, out int kupu)
        {
            int karesi;
            karesi = a * a ;
            kupu = a * a * a; //metodun çağrıldığı yerde out ile belirtilen parametreye değerini gönderecek
            return karesi; // fonsiyon return ile sadece karesini döndürecek
        }
        //ref örn. metodu
        static void degistir(ref int x, ref int y)
        {
            int tmp = x; //x değeri tmp adlı geçici bir değişkene atandı
            x = y; //y değeri x'e atandı, x değişkeni y'nin değerini aldı
            y = tmp; // geçici değişkene atanmış olan x'in ilk değeri 'ye atanarak x ve y'nin değerleri değiştirilmiş oldu
        }
    }
}
