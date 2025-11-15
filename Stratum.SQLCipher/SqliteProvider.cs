namespace Stratum.SQLCipher;

public static class SqliteProvider
{
    public static void Init()
    {
        SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_sqlcipher()); 
    } 
}