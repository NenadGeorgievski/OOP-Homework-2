using Encrypter;

string encryptedString  = EncrypterClass.Encrypt("mynameisnenad");
Console.WriteLine(encryptedString);

string decryptedString = EncrypterClass.Decrypt("mynameisnenad");
Console.WriteLine(decryptedString);