using System;

namespace AspnCore_NHibernate1.Models
{
    public class Livro
    {
        public virtual int LivroId { get; set; }
        public virtual string Titulo { get; set; }
        public virtual DateTime DataCadastro { get; set; }
    }
}
