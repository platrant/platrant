using UnityEngine;

public class EnemyController : MonoBehaviour {

    [SerializeField]
    private int movementSpeed = 1;

    [SerializeField]
    private PlayerHealthHandler playerHealthHandler;

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag(TagName.EnemyWayPoint))
        {
            movementSpeed= -movementSpeed;
            gameObject.transform.Rotate(0, 180, 0);
        }
        else if (coll.gameObject.CompareTag(TagName.Player))
        {
            playerHealthHandler.LoseLife();
        }
    }
}
