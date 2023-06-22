using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoyaDoyaAnadolu.DATA
{
    public class Ozellik
    {
        public int Id { get; set; } //otomatik artan oldu. adı Id old için kendi anlıyor. Prımary key kabul edilir. defaultı da ıdentıty.

        [MaxLength(50)]
        public string Ad { get; set; } = null!;  //null girilemez.

        //[ForeignKey]
        public int SehirId { get; set; }  //bir classadı + ıd seklinde isimlendirirsek bunun foreıgn key oldugu anlar.
        //Sehir adında clasımız var. Biz sehirıd ismi verdik bu bir gelenektir foreign key oldu.


        //üsttekiler sütundur.
        //--------------------------------------------------------------------
        //alttakiler navigation propertydir.entity frame worku eğitmek için bu navigation property kullanılır.
        //iki class arasında bağ yapar. bizim bu proje teke çok ilişki o yüzden bu classta tek özellikle bağ koyduk ama 
        //sehir icine liste koyduk bu bire çok ilişki oldu.
        //iki classa da List tipinde navigation property yaparsak bu ÇOKA ÇOK İLİŞKİ OLUR.

        //Navigation Property
        public Sehir Sehir { get; set; } = null!;
    }
}
