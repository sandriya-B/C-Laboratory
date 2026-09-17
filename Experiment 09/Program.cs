using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Server=localhost;Database=CollegeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        string query = "SELECT * FROM Student";

        using SqlConnection con = new SqlConnection(connectionString);

        SqlDataAdapter adapter = new SqlDataAdapter(query, con);

        DataSet ds = new DataSet();

        adapter.Fill(ds, "Student");

        Console.WriteLine("Student Details");
        Console.WriteLine("----------------------------");

        DataTable? table = ds.Tables["Student"];

        if (table != null)
        {
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(
                    $"ID: {row["Id"]}, Name: {row["Name"]}, Department: {row["Department"]}"
                );
            }
        }

        Console.WriteLine();
        Console.WriteLine("Data retrieved successfully.");
        Console.WriteLine("Data is stored in the disconnected DataSet.");
    }
}