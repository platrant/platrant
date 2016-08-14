using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rgBody;
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float jumpSpeed;
    [SerializeField]
    private Transform[] groundedPoints;
    [SerializeField]
    private float rotationIntensity = 20;

    private Vector2 originalPosition;
    private Quaternion originalRotation;
    private int score;

    private bool rotating;

    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        rgBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontalDirection = GetHorizontalDirection();
        HandleHorizontalMovement(horizontalDirection);
        HandleJump(horizontalDirection);
        if(rotating)
        {
            transform.Rotate(Vector3.forward * rotationIntensity);
        }
    }


    public void ResetPosition()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
        rotating = false;
    }

    public void Rotate()
    {
        rotating = true;
    }

    private float GetHorizontalDirection()
    {
        return Input.GetAxis("Horizontal") != 0 ? Input.GetAxis("Horizontal") : GetVimKeysIfPressed();
    }

    private float GetVimKeysIfPressed()
    {
        if(Input.GetKey("h"))
            return -1;
        return Input.GetKey("l") ? 1 : 0;
    }

    private void HandleHorizontalMovement(float horizontalDirection)
    {
        rgBody.velocity = new Vector2(horizontalDirection * movementSpeed, rgBody.velocity.y);
    }

    private void HandleJump(float horizontalDirection)
    {
        if(ShouldJump()){
            rgBody.velocity = new Vector2(horizontalDirection * movementSpeed, jumpSpeed);
        };
    }

    private bool ShouldJump()
    {
        return Input.GetButton("Jump") && rgBody.velocity.y == 0;
    }

}
