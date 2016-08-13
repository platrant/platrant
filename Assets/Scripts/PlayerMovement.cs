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
        if(ShouldJump()){
            rgBody.velocity = new Vector2(horizontal * movementSpeed, 3);
        };
    }

    private bool ShouldJump()
    {
        return Input.GetButton("Jump") && rgBody.velocity.y == 0;
    }
}
