using System;
using System.Text;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

// Hardcoded secret (CodeQL alert)
string password = "SuperSecret123";

Console.Write("Enter username: ");

// User input (CodeQL source)
string username = Console.ReadLine();

Console.WriteLine($"Hello {username}");

// Insecure hash algorithm (CodeQL alert)
using (MD5 md5 = MD5.Create())
{
    byte[] inputBytes = Encoding.ASCII.GetBytes(username);
    byte[] hashBytes = md5.ComputeHash(inputBytes);

    Console.WriteLine("MD5 Hash: " + Convert.ToHexString(hashBytes));
}

// Hardcoded connection string (CodeQL alert)
var connectionString =
    "Server=localhost;Database=test;User Id=sa;Password=123456;";

using var connection = new SqlConnection(connectionString);

connection.Open();

// SQL Injection vulnerability (CodeQL alert)
var query =
    "SELECT * FROM Users WHERE Username = '" + username + "'";

var command = new SqlCommand(query, connection);

var reader = command.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine(reader["Username"]);
}

Console.WriteLine("Done.");
Console.ReadKey();
