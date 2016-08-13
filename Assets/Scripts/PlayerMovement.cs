using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rgBody;
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float jumpSpeed;
    [SerializeField]
    private Transform[] groundedPoints;

    private int score;

    void Start()
    {
        rgBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontalDirection = GetHorizontalDirection();
        HandleHorizontalMovement(horizontalDirection);
        HandleJump(horizontalDirection);
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

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag.Equals("Coin"))
        {
            score++;
            Destroy(coll.gameObject);
            GameObject.Find("Score").GetComponent<UnityEngine.UI.Text>().text = "Score: " + score;
        }
    }

}
