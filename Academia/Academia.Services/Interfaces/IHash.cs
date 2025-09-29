namespace Academia.Services.Interfaces;

public interface IHash
{
    string Hash(string password);
    bool Verify(string password, string hashedPassword);
}