using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
