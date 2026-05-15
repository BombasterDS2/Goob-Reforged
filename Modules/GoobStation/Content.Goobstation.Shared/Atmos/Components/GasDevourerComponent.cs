namespace Content.Goobstation.Shared.Atmos;

/// <summary>
/// Allows entity to devour nearby gases and put them inside GasMixtureHolderComponent
/// </summary>
[RegisterComponent]
public sealed partial class GasDevourerComponent : Component
{
    /// <summary>
    /// Devouring speed in L/s
    /// </summary>
    [DataField]
    public float TransferRate = 100;
}
