namespace Log.WebApi.Mssql.Data.Db
{
    using System.Data.Entity;

    public partial class MssqlLogContext : DbContext
    {
        public MssqlLogContext()
            : base("name=MssqlLogContext")
        {
            Database.SetInitializer<MssqlLogContext>(new CreateDatabaseIfNotExists<MssqlLogContext>());
        }

        public virtual DbSet<Logs_Nuget> Logs_Nuget { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
