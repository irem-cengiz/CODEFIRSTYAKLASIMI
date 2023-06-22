using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoyaDoyaAnadolu.DATA
{
    //[Table("Cities")]  //tablo adı 
    public class Sehir
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //otomatik artan yapma elle giriş olacak demektir. (.Identıty) dersek otomatik artan olur.
        public int Plaka { get; set; }  //bir üst satıra [key] yapınca primary key oldu.
        [MaxLength(50)]
        [Column ("CityName")]  //kolon adı
        public string Ad { get; set; } = null!;//bir değer girmezsek nvarchar(max) olur. [MaxLength(50)] sınırlama getirdik.NULL GİRİLEMEZ.

        //public string? Ad { get; set; }  NULL GİRİLEBİLİR DEMEK.

        public List<Ozellik> Ozellikler { get; set; } = new(); //bu Navigation Property'dir.!!****
        //Sehirden özelliklerine geçeceksin demis oluyoruz.
        //sehri cagırdık özl olmasa da tablosu gelsin demektir.  = new();
        


    }
}
