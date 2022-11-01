namespace Laison.MES.Domain.Shared
{
    public static class MESDbProperties
    {
        public static string DbTablePrefix { get; set; } = "MES";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "MES";
    }
}
