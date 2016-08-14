using UnityEngine;
using System.Collections;

public class PlayerHealthManager : MonoBehaviour {

    [SerializeField]
    private int remainingLives = 5;

    [SerializeField]
    private LevelManager levelManager;

    public int RemainingLives
    {
        get {return remainingLives;}
        set {remainingLives = value;}
    }

    public void LoseLife()
    {
        remainingLives--;
        CheckIfAlive();
    }

    public int GetRemainingLives()
    {
        return remainingLives;
    }

    public bool IsAlive()
    {
        return remainingLives >= 0;
    }

    private void CheckIfAlive()
    {
        if(remainingLives <= 0)
        {
            levelManager.GameOver();
        }
    }

	void Start() {}
	void Update() {}
}
