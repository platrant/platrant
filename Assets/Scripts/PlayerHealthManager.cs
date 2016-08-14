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
        if(!IsAlive())
            levelManager.GameOver();
    }

    public bool IsAlive()
    {
        return remainingLives > 0;
    }
}
