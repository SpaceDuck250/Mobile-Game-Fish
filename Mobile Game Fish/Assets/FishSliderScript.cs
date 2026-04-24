using UnityEngine;
using UnityEngine.UI;

public class FishSliderScript : MonoBehaviour
{
    [SerializeField]
    private float timer;
    public float timeUntilCaught;

    public Slider fishSlider;

    public bool runTimer;

    public FishCatchingManager fishCatchingManager;
    public FishGeneratorScript fishGeneratorScript;

    private void Start()
    {
        timer = timeUntilCaught / 2;
    }

    private void Update()
    {
        if (!runTimer)
        {
            return;
        }

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = 0;
            runTimer = false;

            // Invoke a OnFishEscape event
        }

        UpdateSlider();
    }

    public void StartTimer()
    {
        // timer starts at around half so player doesnt win or lose instantly
        timer = timeUntilCaught / 2;
        runTimer = true;
    }

    public void AddToTimerValue(float amountInSeconds)
    {
        timer += amountInSeconds;
        if (timer >= timeUntilCaught)
        {
            fishCatchingManager.OnFishFinallyCaught?.Invoke(fishGeneratorScript.GenerateRandomFish(fishGeneratorScript.PickRandomRarity()));
        }

        UpdateSlider();
    }

    public void UpdateSlider()
    {
        float newSliderValue = timer / timeUntilCaught;
        fishSlider.value = newSliderValue;
    }
}
