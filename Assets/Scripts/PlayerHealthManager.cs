using UnityEngine;
using System.Collections;

public class PlayerHealthManager : MonoBehaviour {

    int remainingLives = 3;

    public void LoseLife()
    {
        remainingLives--;
        CheckIfAlive();
    }

    public int GetRemainingLives()
    {
        return remainingLives;
    }

    private void CheckIfAlive()
    {
        if(remainingLives <= 0)
        {
            Debug.Log("you daed");
        }
    }

	void Start() {}
	void Update() {}
}
