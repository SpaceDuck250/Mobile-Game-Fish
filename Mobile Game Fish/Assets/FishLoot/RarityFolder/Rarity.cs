using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Rarity", menuName = "Scriptable Objects/Rarity")]
public class Rarity : ScriptableObject
{
    public string rarityName;
    public float rarityWeight;

    public List<FishType> fishPoolList = new List<FishType>();
}
