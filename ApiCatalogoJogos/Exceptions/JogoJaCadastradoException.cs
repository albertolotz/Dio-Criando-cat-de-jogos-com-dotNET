using System;
namespace ApiCatalogoJogos.Exceptions
{
  public class JogoJaCadastradoException : Exception
  {
    public JogoJaCadastradoException()
        : base("Este Jogo já está Cadastrado")
    { }

  }
}