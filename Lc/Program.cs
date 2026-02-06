using System;
using System.Data.SqlClient;

string Password = "SuperSecret123";

Console.WriteLine("fatihd");


using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
{
	byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("fatihd");
	byte[] hashBytes = md5.ComputeHash(inputBytes);

	Console.WriteLine(Convert.ToHexString(hashBytes));

	Console.WriteLine("Hello World");
}

var connectionString = "Server=.;Database=test;User Id=sa;Password=123456;";

using var connection = new SqlConnection(connectionString);

connection.Open();

var query = "SELECT * FROM Users WHERE Username = '" + username + "'";

var command = new SqlCommand(query, connection);

var reader = command.ExecuteReader();

while (reader.Read())
{
	Console.WriteLine(reader["Username"]);
}

Console.ReadKey();
