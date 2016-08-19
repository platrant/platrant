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

    bool grounded = false;
    [SerializeField]
    Transform rightLeg;
    [SerializeField]
    Transform leftLeg;
    float groundRadius = 0.5f;
    [SerializeField]
    public LayerMask whatIsGround;

    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        rgBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        grounded = IsGrounded(leftLeg) || IsGrounded(rightLeg);

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

    private bool IsGrounded(Transform foot)
    {
        return Physics2D.OverlapCircle(foot.position, groundRadius, whatIsGround);
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

    private bool IsFootGrounded(Vector3 pos, Vector3 foot)
    {
        Debug.DrawRay(pos - foot, Vector2.down * 0.2f);
        return Physics2D.Raycast(pos - foot, Vector2.down, 0.2f);
    }

    private Collider2D GetCollider()
    {
        Collider2D collider = GetComponent<Collider2D>();
        return collider;
    }

    private void HandleJump(float horizontalDirection)
    {
        if(ShouldJump()){
            rgBody.AddForce(new Vector2(horizontalDirection * movementSpeed, jumpSpeed), ForceMode2D.Impulse);
        };
    }

    private bool ShouldJump()
    {
        return Input.GetButton("Jump") && grounded;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag(TagName.Coin))
        {
            score++;
            Destroy(coll.gameObject);
            GameObject.Find("Score").GetComponent<UnityEngine.UI.Text>().text = "Score: " + score;
        }
    }

}
