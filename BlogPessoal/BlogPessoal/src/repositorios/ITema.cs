using System.Collections.Generic;
using BlogPessoal.src.dtos;
using BlogPessoal.src.modelos;

namespace BlogPessoal.src.repositorios
{
    /// <summary>
    /// <para>Resumo: Responsavel por representar ações de CRUD de tema</para>
    /// <para>Criado por: Yasmim Cristine</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public interface ITema
    {
        void NovoTema(NovoTemaDTO tema);
        void AtualizarTema(AtualizarTemaDTO tema);
        void DeletarTema(int id);
        TemaModelo PegarTemaPeloId(int id);
        List<TemaModelo> PegarTemaPelaDescricao(string descricao);
    }

}