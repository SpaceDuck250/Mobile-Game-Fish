using UnityEngine;

public class ReelClickedAnimator : MonoBehaviour
{
    public Animator animator;
    public ReelClickerScript reelClicker;

    private void Start()
    {
        reelClicker.OnReelMoverClicked += OnReelMoverClicked;
    }

    private void OnDestroy()
    {
        reelClicker.OnReelMoverClicked -= OnReelMoverClicked;

    }

    private void OnReelMoverClicked(bool hit)
    {
        animator.SetTrigger("clicked");
    }
}
