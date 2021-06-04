using System.ComponentModel.DataAnnotations;

namespace ApiCatalogoJogos.DTOInputModel
{
  public class JogoInputModel
  {
    [Required]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome do jogo precisa conter entre 3 e 100 caracteres.")]
    public string Nome { get; set; }
    [Required]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome da produtora precisa conter entre 3 e 100 caracteres.")]
    public string Produtora { get; set; }
    [Required]
    [Range(1, 1000, ErrorMessage = "O preço dever ser entre 1 e 1000 reais")]
    public double Preco { get; set; }
  }
}