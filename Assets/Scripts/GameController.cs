using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int score = 0;
    public string scorePrefix = "Score: ";

    public string scoreText = null;

    public Text gameOverText = null;

    public static GameController gameController = null;

    void Awake()
    {
        gameController = this;    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreText != null)
        {
            scoreText = scorePrefix + score.ToString();
        }
    }
}
