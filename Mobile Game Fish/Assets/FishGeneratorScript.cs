using UnityEngine;

public class FishGeneratorScript : MonoBehaviour
{
    public FishType fishType;

    private void Start()
    {
        Fish newFish = new Fish(fishType, 5);

        print(newFish);
    }
}
