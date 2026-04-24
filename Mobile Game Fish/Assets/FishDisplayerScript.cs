using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FishDisplayerScript : MonoBehaviour
{
    public Image fishIconObj;
    public TextMeshProUGUI fishNameObj;
    public TextMeshProUGUI fishWeightObj;
    public TextMeshProUGUI fishRarityObj;

    public GameObject fishDisplayerObj;

    public float waitTime;

    public void DisplayFish(Fish fish)
    {
        Sprite fishIcon = fish.fishType.sprite;
        string fishName = fish.fishType.name;
        float fishWeight = fish.weight;
        string fishRarity = fish.fishType.rarity.ToString();

        fishIconObj.sprite = fishIcon;
        fishNameObj.text = fishName;
        fishWeightObj.text = "Weight: " + fishWeight + "kg";
        fishRarityObj.text = "Rarity: " + fishRarity;

        fishDisplayerObj.SetActive(true);

        Invoke("CloseDisplay", waitTime);
    }

    private void CloseDisplay()
    {
        fishDisplayerObj.SetActive(false);
    }
}
