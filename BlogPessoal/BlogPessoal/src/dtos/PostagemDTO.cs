using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.src.dtos
{
    /// <summary>
    /// <para>Resumo: Classe espelho para criar uma nova postagem</para>
    /// <para>Criado por: Yasmim Cristine</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 15/05/2022</para>
    /// </summary>
    public class NovaPostagemDTO
    {
        [Required, StringLength(30)]
        public string Titulo { get; set; }

        [Required, StringLength(100)]
        public string Descricao { get; set; }

        public string Foto { get; set; }

        [Required]
        public string EmailCriador { get; set; }

        [Required]
        public string DescricaoTema { get; set; }

        public NovaPostagemDTO(string titulo, string descricao, string foto, string emailCriador, string descricaotema)
        {
            Titulo = titulo;
            Descricao = descricao;
            Foto = foto;
            EmailCriador = emailCriador;
            DescricaoTema = descricaotema;
        }

    }
    /// <summary>
    /// <para>Resumo: Classe espelho para alterar uma postagem</para>
    /// <para>Criado por: Yasmim Cristine</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 15/05/2022</para>
    /// </summary>
    public class AtualizarPostagemDTO
    {
        [Required]
        public int Id { get; set;}
        
        [Required, StringLength(30)]
        public string Titulo { get; set; }

        [Required, StringLength(100)]
        public string Descricao { get; set; }

        public string Foto { get; set; }

        [Required]
        public string DescricaoTema { get; set; }

        public AtualizarPostagemDTO(int id, string titulo, string descricao, string foto, string descricaoTema)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Foto = foto;
            DescricaoTema = descricaoTema;
        }
    }

}