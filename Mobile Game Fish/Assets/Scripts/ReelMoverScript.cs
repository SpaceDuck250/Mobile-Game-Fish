using UnityEngine;

public class ReelMoverScript : MonoBehaviour
{
    public float moveSpeed;

    public Transform leftEndPoint, rightEndPoint;

    public Transform target;

    public void SwitchDirection()
    {
        target = target == leftEndPoint ? rightEndPoint : leftEndPoint;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * moveSpeed);
        
        if (CheckIfReachedEndPoint())
        {
            SwitchDirection();
        }
    }

    private bool CheckIfReachedEndPoint()
    {
        if (transform.position == leftEndPoint.position || transform.position == rightEndPoint.position)
        {
            return true;
        }

        return false;
    }
}
