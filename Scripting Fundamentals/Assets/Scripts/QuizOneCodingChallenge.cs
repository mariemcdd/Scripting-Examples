using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    public int Score = 0;
    public string PlayerName = "marie";
    public int Health = 100;

    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
        PrintPlayerName();
        DecreaseHealth();
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    private void IncreaseScore(int amount)
    {
        // either one works, don't need int amount if adding 10
        Score += 10;
        Score = Score + amount;
    }

    private void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    private int DecreaseHealth()
    {
        Health -= 20;
    }
}
