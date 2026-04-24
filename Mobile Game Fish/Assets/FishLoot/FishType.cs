using UnityEngine;

[CreateAssetMenu(fileName = "FishLoot", menuName = "Scriptable Objects/FishLoot")]
public class FishType : ScriptableObject // General data not including unique rng data like weight and quality and stuff
{
    public string name;
    public Sprite sprite;
    public bool isFish;

    //rarity just for display
    public LootRarity rarity;

    // For minigame
    public float reelMoverSpeed;
    public float redAreaSizeFactor;
}

public enum LootRarity
{
    common,
    rare,
    legendary
}