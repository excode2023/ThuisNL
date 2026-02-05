using System.Text.RegularExpressions;

namespace ThuisNL.Core.ValueObjects;

public sealed class Emails
{
    private static readonly Regex EmailRegex =
        new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

    public string Value { get; }

    // Constructor privado → solo se crea con el método Create
    private Emails(string value)
    {
        Value = value;
    }

    // Método fábrica que valida todo
    public static Emails Create(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException("El email no puede estar vacío.");

        var normalized = input.Trim().ToLowerInvariant();

        if (!EmailRegex.IsMatch(normalized))
            throw new ArgumentException("El formato del email no es válido.");

        return new Emails(normalized);
    }

    public override string ToString() => Value;

    // Para que EF Core lo compare por valor
    public override bool Equals(object? obj) => obj is Emails other && Value == other.Value;
    public override int GetHashCode() => Value.GetHashCode();
}