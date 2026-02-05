using ThuisNL.Core.ValueObjects;

namespace ThuisNL.Core.Entities;

public class User
{
    public Guid Id { get; private set; }
    public Emails Email { get; private set; } = null!;           // EF lo rellenará
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string DisplayName { get; private set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; private set; }
    public bool IsVerified { get; private set; }

    // Constructor privado vacío → solo para EF Core (no asigna nada raro)
    private User() { }

    // Constructor real que usaremos nosotros
    public User(Guid id, string emailInput, string firstName, string lastName, string displayName)
    {
        if (id == Guid.Empty)
            throw new ArgumentException("El Id no puede ser vacío.");

        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentException("El nombre es obligatorio.");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentException("El apellido es obligatorio.");

        if (string.IsNullOrWhiteSpace(displayName))
            throw new ArgumentException("El nombre visible es obligatorio.");

        Id = id;
        Email = Emails.Create(emailInput);  // ← Aquí validamos y creamos el Value Object
        FirstName = firstName.Trim();
        LastName = lastName.Trim();
        DisplayName = displayName.Trim();
        CreatedAt = DateTimeOffset.UtcNow;
        IsVerified = false;
    }

    public void Verify()
    {
        IsVerified = true;
    }
}