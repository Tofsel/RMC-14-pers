﻿using Content.Shared._RMC14.Marines.Skills;
using Content.Shared.FixedPoint;
using Content.Shared.Tools;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._RMC14.Repairable;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(RMCRepairableSystem))]
public sealed partial class RMCRepairableComponent : Component
{
    [DataField, AutoNetworkedField]
    public FixedPoint2 Heal = FixedPoint2.New(-50);

    [DataField, AutoNetworkedField]
    public TimeSpan Delay = TimeSpan.FromSeconds(4);

    [DataField, AutoNetworkedField]
    public EntProtoId<SkillDefinitionComponent> Skill = "RMCSkillEngineer";

    [DataField, AutoNetworkedField]
    public float[] SkillDelayMultipliers = [1f, 0.75f, 0.5f, 0.375f, 0.25f];

    [DataField, AutoNetworkedField]
    public SoundSpecifier? Sound = new SoundPathSpecifier("/Audio/Items/welder.ogg");

    [DataField, AutoNetworkedField]
    public ProtoId<ToolQualityPrototype> Quality = "Welding";
}