using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private int score;
    public Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        textScore.text = "Score : " + score;
    }

    public void AddScore()
    {
        score++;
        textScore.text = "Score : " + score;
    }
   

}
