

using System.Data.Entity;
using System.Xml;

namespace DemoForm
{
    public partial class HelloContext : DbContext {
        public HelloContext() : base("name=HelloContext") { }

        public DbSet<User> Users { get; set; }

        //public HelloContext(DbContextOptions<HelloContext> options) : base(options) { }
        public  DbSet<Lesson> Lessons
        {
            get;
            set;
        }
        //public virtual DbSet<User> Users
        //{
        //    get;
        //    set;
        //}

        public DbSet<Teacher> Teachers
        {
            get;
            set;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=hello.db");
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //        modelBuilder.Entity<Lesson>(entity =>
        //        {
        //            entity.ToTable("lessons");
        //            entity.HasKey(e => e.id);
        //            entity.Property(e => e.lessonName).HasColumnType("VARCHAR");
        //            entity.Property(e => e.createdate).HasColumnType("DATETIME").HasDefaultValueSql("CURRENT_TIMESTAMP");
        //            entity.Property(e => e.userId).HasColumnType("INTEGER");
        //            entity.Property(e => e.TeacherId).HasColumnType("INTEGER");

        //            entity.HasOne(d => d.CuurentTeacher)
        //                .WithMany(p => p.Lessons)
        //                .HasForeignKey(d => d.TeacherId);

        //        });

        //        modelBuilder.Entity<User>(entity => {
        //            entity.HasKey(e => e.id);
        //            entity.Property(e => e.name).HasColumnType("VARCHAR");
        //            entity.Property(e => e.createdate).HasColumnType("DATETIME").HasDefaultValueSql("CURRENT_TIMESTAMP");            

        //        });


        //        modelBuilder.Entity<Teacher>(entity => {
        //            entity.HasKey(e => e.id);
        //            entity.Property(e => e.name).HasColumnType("VARCHAR");
        //            entity.Property(e => e.section).HasColumnType("VARCHAR");
        //            entity.Property(e => e.createdate).HasColumnType("DATETIME").HasDefaultValueSql("CURRENT_TIMESTAMP");

        //        });

        //        OnModelCreatingPartial(modelBuilder);
        //}
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }



}
