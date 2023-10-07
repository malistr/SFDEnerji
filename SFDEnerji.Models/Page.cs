using System.ComponentModel.DataAnnotations.Schema;

namespace SFDEnerji.Models
{
    [Table("Pages")]

    public class Page : BaseModel
    {
        public string Content { get; set; }
        public string Slug { get; set; }// id yerine kullanacgaımız okunaklı bir anahtar kelime/sayfa görüntüleme erknaımız arsa sftenerji.com/page72 GİBİ O 2NİN GÖZĞKMESİ HOŞ DEĞİL BU YUZDEN skage kullanıyoz

        public string? Thumbnail { get; set; }

        public int ViewCount { get; set; }
        public virtual ICollection<Picture>? Pictures { get; set; } = new List<Picture>();
        public virtual ICollection<Meta>? Metas { get; set; } = new List<Meta>();


    }
}
