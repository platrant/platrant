using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
