using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    public int score = 0;
    public string PlayerName = "marie";
    public float health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IncreaseScore();
        PrintPlayerName();
        DecreaseHealth();
    }

    private int IncreaseScore(int 0)
    {
        return score + 10;
    }

    private void PrintPlayerName()
    {

    }

    private int DecreaseHealth(int 100)
    {
        return health - 20;
    }
}
