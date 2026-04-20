using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public float smoothValue;

    private int moveDirection = 0;

    private Vector3 refVelocity;

    public void MoveRight()
    {
        moveDirection = 1;
    }

    public void MoveLeft()
    {
        moveDirection = -1;
    }

    public void StopMoving()
    {
        moveDirection = 0;
    }

    private void FixedUpdate()
    {
        Vector3 targetVelocity = new Vector3(moveDirection * moveSpeed, 0, 0);
        rb.linearVelocity = Vector3.SmoothDamp(rb.linearVelocity, targetVelocity, ref refVelocity, smoothValue * Time.fixedDeltaTime);
    }
}
