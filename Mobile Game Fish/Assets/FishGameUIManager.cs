using UnityEngine;

public class FishGameUIManager : MonoBehaviour
{
    public FishCatchingManager fishManager;

    public GameObject fishingGamePanel;
    public GameObject fishButton;

    public FishDisplayerScript fishDisplayerScript;

    private void Start()
    {
        fishManager.OnFishGameStarted += SetupReelingGameUI;
        fishManager.OnFishFinallyCaught += FinishReelingGameUI;
    }

    private void OnDestroy()
    {
        fishManager.OnFishGameStarted -= SetupReelingGameUI;
        fishManager.OnFishFinallyCaught -= FinishReelingGameUI;
    }

    private void SetupReelingGameUI()
    {
        fishButton.SetActive(false);
        fishingGamePanel.SetActive(true);
    }

    private void FinishReelingGameUI(Fish fishCaught)
    {
        fishButton.SetActive(true);
        fishingGamePanel.SetActive(false);

        ShowFishCaughtOnScreen(fishCaught);
    }

    private void ShowFishCaughtOnScreen(Fish fishCaught)
    {
        fishDisplayerScript.DisplayFish(fishCaught);
    }
}
