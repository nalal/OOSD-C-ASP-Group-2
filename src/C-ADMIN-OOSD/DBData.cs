using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

/*
    FILE: DBCall.cs
    FUCNTION: Interperate calls to MSSQL DB

    Authors: 
    Noah German (Alias: Nalal/Nacalal/Nac)

    INIT DATE (D/M/Y): 13/12/2018
*/

public class DBData
{
    public static string User = "";
    public static string DB = "";
    public static string IP = "";
    public static string Port = "";
    public static string Pass = "";
    public static void DBCon()
    {
        string testscript1 = "CREATE TABLE TestTable(id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, name VARCHAR(100));";
        string connStr = "server=" + IP +";user=" + User + ";database=OOSD_DB" + ";port=" + Port + ";password=" + Pass;
        MySqlConnection conn = new MySqlConnection(connStr);
        conn.Open();
        MySqlScript script = new MySqlScript(conn, testscript1);
    }
}