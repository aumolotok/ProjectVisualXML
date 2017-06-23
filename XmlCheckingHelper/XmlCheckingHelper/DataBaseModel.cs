namespace XmlCheckingHelper
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBaseModel : DbContext
    {
        public DataBaseModel()
            : base("name=DataBaseModel")
        {
        }

        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Questions>()
                .Property(e => e.QuestionCd)
                .IsFixedLength();

            modelBuilder.Entity<Questions>()
                .Property(e => e.AcordNumber)
                .IsFixedLength();

            modelBuilder.Entity<Questions>()
                .Property(e => e.AcordText)
                .IsUnicode(false);

            modelBuilder.Entity<Questions>()
                .Property(e => e.Section)
                .IsUnicode(false);

            modelBuilder.Entity<Questions>()
                .Property(e => e.HelpText)
                .IsUnicode(false);
        }
    }
}
