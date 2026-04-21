using UnityEngine;
using System;

public class ReelClickerScript : MonoBehaviour
{
    public bool inGreenZone = false;

    public float redDamage;
    public float greenAttack;

    public event Action<bool> OnReelMoverClicked;

    public BoxCollider2D greenZone;

    public void TryClick()
    {
        if (greenZone.bounds.Contains(transform.position))
        {
            inGreenZone = true;
        }
        else
        {
            inGreenZone = false;
        }

        bool hit = inGreenZone;
        OnReelMoverClicked?.Invoke(hit);
    }
}
