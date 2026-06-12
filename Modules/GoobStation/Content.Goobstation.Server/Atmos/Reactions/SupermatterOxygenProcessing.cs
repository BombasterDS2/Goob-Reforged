using Content.Server.Atmos;
using Content.Server.Atmos.EntitySystems;
using Content.Server.Power.EntitySystems;
using Content.Shared.Atmos;
using Content.Shared.Atmos.Reactions;

namespace Content.Goobstation.Server.Atmos.Reactions;

/// <summary>
///     Increases internal energy of supermatter crystal by consuming oxygen. Consumes only 50% of gas.
/// </summary>
public sealed partial class SupermatterOxygenProcessing : IGasReactionEffect
{
    [Dependency] private BatterySystem _batterySystem = default!;

    public ReactionResult React(GasMixture mixture, IGasMixtureHolder holder, AtmosphereSystem atmosphere, float heatScale)
    {
        var initialOxy = mixture.GetMoles(Gas.Oxygen);
    }
}