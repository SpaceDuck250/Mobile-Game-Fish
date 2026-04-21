using UnityEngine;

public struct Fish 
{
    public Fish(FishType fishType, float weight)
    {
        this.fishType = fishType;
        this.weight = weight;
    }

    public FishType fishType;
    public float weight;
}
