using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rgBody;
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private Transform[] groundedPoints;

    private int score;

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

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Coin")
        {
            score++;
            Destroy(coll.gameObject);
            Debug.Log("New Score: " + score);
        }
    }

}
