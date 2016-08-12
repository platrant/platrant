using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rgBody;
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private Transform[] groundedPoints;
    void Start()
    {
        rgBody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        MovementHandler(horizontal);
    }
    private void MovementHandler(float horizontal)
    {
        rgBody.velocity = new Vector2(horizontal * movementSpeed, rgBody.velocity.y);

        ShouldJump(horizontal);
    }
    private void ShouldJump(float horizontal)
    {
        if (Input.GetButtonDown("Jump") && rgBody.velocity.y == 0)
        {
            rgBody.velocity = new Vector2(horizontal * movementSpeed, 3);
        }
    }
}
