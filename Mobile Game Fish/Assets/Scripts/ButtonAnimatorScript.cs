using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimatorScript : MonoBehaviour
{
    public Animator buttonAnimator;

    public bool held = false;

    public float sizeIncrease;
    public Color desiredShade;
    public float smoothValue;

    public Vector3 originalScale;
    public Color originalShade;

    public RectTransform rectTransform;

    public Image image;

    private void Start()
    {
        originalScale = rectTransform.sizeDelta;
        originalShade = image.color;
    }

    private void Update()
    {
        if (!held)
        {
            return;
        }

        LerpToHeldAnimation();
    }

    public void PlayHoldAnimation()
    {
        held = true;
    }

    public void StopHoldAnimation()
    {
        held = false;

        rectTransform.sizeDelta = originalScale;
    }

    public void LerpToHeldAnimation()
    {
        Vector3 desiredScale = originalScale * sizeIncrease;
        rectTransform.sizeDelta = Vector3.Lerp(rectTransform.sizeDelta, desiredScale, smoothValue * Time.deltaTime);
    }

    public void PlayClickedAnimation()
    {
        buttonAnimator.SetTrigger("clicked");
    }
}
