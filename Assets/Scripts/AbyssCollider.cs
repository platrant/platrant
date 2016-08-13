using UnityEngine;
using System.Collections;

public class AbyssCollider : MonoBehaviour {

    [SerializeField]
    private LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("In on trigger enter");
        levelManager.RequestQuit();
    }

	void Start () { }
	void Update () { }
}
