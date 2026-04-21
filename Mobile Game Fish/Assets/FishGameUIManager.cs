using UnityEngine;

public class FishGameUIManager : MonoBehaviour
{
    public FishCatchingManager fishManager;

    public GameObject fishingGamePanel;
    public GameObject fishButton;

    private void Start()
    {
        fishManager.OnFishGameStarted += SetupFishingGameUI;
    }

    private void OnDestroy()
    {
        fishManager.OnFishGameStarted -= SetupFishingGameUI;

    }

    private void SetupFishingGameUI()
    {
        fishButton.SetActive(false);
        fishingGamePanel.SetActive(true);
    }
}
