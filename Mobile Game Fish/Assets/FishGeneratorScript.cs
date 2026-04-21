using UnityEngine;
using System.Collections.Generic;

public class FishGeneratorScript : MonoBehaviour
{
    public List<Rarity> rarityList = new List<Rarity>();

    public float minWeight;
    public float maxWeight;

    public void PrintFish()
    {
        Fish fish = GenerateRandomFish(PickRandomRarity());
        print(fish.fishType + " " + fish.weight);
    }

    public Rarity PickRandomRarity()
    {
        float randomNum = Random.value;
        float cummulative = 0;

        foreach (Rarity rarity in rarityList)
        {
            cummulative += rarity.rarityWeight;
            if (randomNum < cummulative)
            {
                print(rarity);
                return rarity;
            }
        }

        return null;
    }

    public Fish GenerateRandomFish(Rarity rarityPool)
    {
        int randomIndex = Random.Range(0, rarityPool.fishPoolList.Count);
        FishType randomFishType = rarityPool.fishPoolList[randomIndex];

        float randomWeight = Random.Range(minWeight, maxWeight);
        randomWeight = Mathf.Round(randomWeight);

        Fish newFish = new Fish(randomFishType, randomWeight);

        return newFish;
    }


}
