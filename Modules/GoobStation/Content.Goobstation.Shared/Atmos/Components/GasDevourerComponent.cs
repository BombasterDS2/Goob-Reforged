namespace Content.Goobstation.Shared.Atmos;

/// <summary>
/// Allows entity to devour nearby gases and put them inside GasMixtureHolderComponent
/// </summary>
[RegisterComponent]
public sealed partial class GasDevourerComponent : Component
{
    /// <summary>
    /// Maximum gas moles that holder can contain
    /// </summary>
    [DataField]
    public float MolesLimit = 0;
}
