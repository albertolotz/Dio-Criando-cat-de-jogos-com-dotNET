using System;

namespace ApiCatalogoJogos.DTOViewModel
{
  public class JogoViewModel
  {
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Produtora { get; set; }
    public string Preco { get; set; }
  }
}