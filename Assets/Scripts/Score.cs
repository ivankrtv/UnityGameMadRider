using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Score : MonoBehaviour
{
    public Text ScoreText, FinalText;
    public static bool isCrashed = false;
    private int CheckPoint = 0;
    public int score = 0;
    public float TimeGenerateOfEnemys = 1, SpeedOfEnemys = 10, SpeedOfPlayer = 10f;
    Coroutine cour;

    private void Start()
    {
        //ScoreText.text = Convert.ToString(score) + " М";
        cour = StartCoroutine("UpdateScore");
    }
    private void Update()
    {
        if (isCrashed)
        {
            StopCoroutine(cour);
        }
        if((score-CheckPoint) == 50)
        {
            TimeGenerateOfEnemys -= 0.2f;
            SpeedOfEnemys += 2f;
            SpeedOfPlayer += 0.5f;
            EnemyGenerate.TimeOfGeneration = TimeGenerateOfEnemys;
            EnemyMove.speed = SpeedOfEnemys;
            MainCarMove.speed = SpeedOfPlayer;
            RoadMove.speed += 2.5f;
            CheckPoint = score;
        }
    }

    IEnumerator UpdateScore()
    {
        while (!isCrashed)
        {
            updateScoreText();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void updateScoreText()
    {
        ScoreText.text = Convert.ToString(score++) + " m";
    }
}
