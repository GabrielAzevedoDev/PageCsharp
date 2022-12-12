using FN.Store.Domain._2.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FN.Store.Data.EF.Maps
{
    class TipoDeProdutoMap : EntityTypeConfiguration<TipoDeProduto>
    {
        public TipoDeProdutoMap()
        {
            //Table 
            ToTable(nameof(TipoDeProduto));


            //PK
            HasKey(pk => pk.Id);

            //Colums
            Property(c => c.Id)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.DataCadastro);
        }
    }
}
