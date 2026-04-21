using UnityEngine;

public class FishSliderSubscriber : MonoBehaviour
{
    public ReelClickerScript reelClicker;
    public FishSliderScript fishSliderScript;

    private void Start()
    {
        reelClicker.OnReelMoverClicked += OnReelMoverClicked;
    }

    private void OnDestroy()
    {
        reelClicker.OnReelMoverClicked -= OnReelMoverClicked;

    }

    private void OnReelMoverClicked(bool onGreen, float changeToSlider)
    {
        fishSliderScript.AddToTimerValue(changeToSlider);
    }
}
