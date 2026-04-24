using UnityEngine;

public class FishSliderSubscriber : MonoBehaviour
{
    public ReelClickerScript reelClicker;
    public FishSliderScript fishSliderScript;
    public FishCatchingManager fishCatchingManager;

    private void Start()
    {
        fishCatchingManager.OnFishGameStarted += OnFishGameStarted;
        reelClicker.OnReelMoverClicked += OnReelMoverClicked;
    }


    private void OnDestroy()
    {
        reelClicker.OnReelMoverClicked -= OnReelMoverClicked;
        fishCatchingManager.OnFishGameStarted -= OnFishGameStarted;


    }

    private void OnFishGameStarted()
    {
        fishSliderScript.StartTimer();
    }

    private void OnReelMoverClicked(bool onGreen, float changeToSlider)
    {
        fishSliderScript.AddToTimerValue(changeToSlider);
    }
}
