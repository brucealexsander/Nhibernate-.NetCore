using AspnCore_NHibernate1.Models;
using FluentNHibernate.Mapping;

namespace AspnCore_NHibernate1.Mapping
{
    public class LivroMap : ClassMap<Livro>
    {
        public LivroMap()
        {
            Id(l => l.LivroId).Column("livroId");
            Map(l => l.Titulo).Column("titulo");
            Map(l => l.DataCadastro).Column("dataCadastro");
            Table("livros");
        }
    }
}
