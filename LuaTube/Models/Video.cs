using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LuaTube.Models;

[Table("Video")]
public class Video
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Name")]
    [Required(ErrorMessage = "O Name é obrigatório")]
    [StringLength(100, ErrorMessage = "O Name deve possuir no máximo 100 caracteres")]
    public string Name { get; set; }


    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "A Descrição é obrigatória")]
    [StringLength(8000, ErrorMessage = "A Descrição deve possuir no máximo 5000 caracteres")]
    public string Description { get; set; }

    [Column(TypeName = "UploadDate")]
    [Display(Name = "Data de publicação")]
    [Required(ErrorMessage = "A Data de publicação é obrigatório")]
    public Int16 UploadDate { get; set; }

    [Display(Name = "Duração (em minutos)")]
    [Required(ErrorMessage = "A Duração é obrigatória")]
    public Int16 Duration { get; set; }




    [Display(Name = "Classificação Etária")]
    [Required(ErrorMessage = "A Classificação Etária é obrigatória")]
    public byte AgeRating { get; set; }

    [StringLength(200)]
    [Display(Name = "Foto")]
    public string Image { get; set; }

    [NotMapped]
    [Display(Name = "Duração")]
    public string HourDuration { get {
        return TimeSpan.FromMinutes(Duration) .ToString(@"%h'h 'mm'min'");
    }}

    public ICollection<VideoTag> Tags { get; set; }
}