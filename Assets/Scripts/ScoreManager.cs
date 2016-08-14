using UnityEngine;

namespace Assets.Scripts
{
    class ScoreManager : MonoBehaviour
    {
        private int score = 0;

        public void UpdateScore()
        {
            score++;
            GameObject.Find("Score").GetComponent<UnityEngine.UI.Text>().text = "Score: " + score;
        }
    }
}
