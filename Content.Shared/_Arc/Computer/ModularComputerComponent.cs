using Content.Shared.Containers.ItemSlots;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._Arc.Computer;

/// <summary>
/// Main component for the ComputerDisk system
/// </summary>
[RegisterComponent, NetworkedComponent]
//[Access(typeof(ComputerDiskSystem))]
public sealed partial class ModularComputerComponent : Component
{
    [DataField]
    public string DiskSlot = "diskSlot";

    [DataField]

    public SoundSpecifier? DiskInsertSound = new SoundPathSpecifier("/Audio/_Arc/computer_startup.ogg");
}
