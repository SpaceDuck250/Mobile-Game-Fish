using UnityEngine;
using UnityEngine.UI;
using System;

public class FishCatchingManager : MonoBehaviour
{
    public event Action OnFishGameStarted;
    public Action<Fish> OnFishFinallyCaught;

    public FishGeneratorScript fishGenerator;

    public int baitLeft;

    public void TryFish()
    {
        if (baitLeft == 0)
        {
            return;
        }

        baitLeft--;

        OnFishGameStarted?.Invoke();
    }

    public void FinallyCatchFish()
    {
        Fish caughtFish = fishGenerator.GenerateRandomFish(fishGenerator.PickRandomRarity());
        OnFishFinallyCaught?.Invoke(caughtFish);
    }

}
