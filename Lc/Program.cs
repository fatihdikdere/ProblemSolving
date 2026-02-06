Console.WriteLine("fatihd");


using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
{
	byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("fatihd");
	byte[] hashBytes = md5.ComputeHash(inputBytes);

	Console.WriteLine(Convert.ToHexString(hashBytes));

	Console.WriteLine("Hello World");
}

Console.ReadKey();