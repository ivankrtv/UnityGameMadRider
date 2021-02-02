using UnityEngine.UI;
using UnityEngine;
using System;

public class Crash : MonoBehaviour
{
    public GameObject Road, Player, ButtonRestart, ScoreText, FinalText, scoreCount;
    public Text FTtext;
    public GameObject LeftTouch, RightTouch;

    void OnTriggerEnter(Collider col)
    {
        LeftTouch.GetComponent<LeftTouch>().isCrashed = true;
        RightTouch.GetComponent<RightTouch>().isCrashed = true;
        Road.GetComponent<RoadMove>().isCrashed = true;
        Player.GetComponent<MainCarMove>().isCrashed = true;
        //Enemy.GetComponent<EnemyMove>().isCrashed = true;
        EnemyMove.isCrashed = true;
        EnemyGenerate.isCrashed = true;
        Score.isCrashed = true;
        ButtonRestart.SetActive(true);
        ScoreText.SetActive(false);
        FinalText.SetActive(true);
        FTtext.text = Convert.ToString(scoreCount.GetComponent<Score>().score) + " m";
    }
}
