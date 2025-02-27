using System.Collections;
using System.Collections.Generic;
using CreatorKitCode;
using UnityEngine;

public class AddSpeedEffect: UsableItem.UsageEffect
{
    public float Duration = 10.0f;
    public int SpeedChange = 5;
    public Sprite EffectSprite;

    public override bool Use(CharacterData user)
    {
        StatSystem.StatModifier modifier = new StatSystem.StatModifier();
        modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
        modifier.Stats.agility = SpeedChange;

        VFXManager.PlayVFX(VFXType.Stronger, user.transform.position);

        user.Stats.AddTimedModifier(modifier, Duration, "AgilityAdd", EffectSprite);

        return true;
    }
}
