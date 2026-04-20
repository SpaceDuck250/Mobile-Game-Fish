using UnityEngine;
using System;

public class ReelClickerScript : MonoBehaviour
{
    public bool inGreenZone = false;

    public float redDamage;
    public float greenAttack;

    public event Action<float> OnReelMoverClicked;

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

        float attackDone = inGreenZone ? greenAttack : redDamage;
        print("hit = " + inGreenZone);
        OnReelMoverClicked?.Invoke(attackDone);
    }
}
