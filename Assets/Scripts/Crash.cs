using UnityEngine.UI;
using UnityEngine;
using System;

public class Crash : MonoBehaviour
{
    public GameObject Road, Player, ScoreText, FinalScore, Record, scoreCount, ButtonReset, ButtonBackMenu, SaveData;
    public Text FTtext, RecordText;
    public GameObject LeftTouch, RightTouch;

    void OnTriggerEnter(Collider col)
    {
        LeftTouch.GetComponent<LeftTouch>().isCrashed = true;
        RightTouch.GetComponent<RightTouch>().isCrashed = true;
        RoadMove.isCrashed = true;
        MainCarMove.isCrashed = true;
        EnemyMove.isCrashed = true;
        EnemyGenerate.isCrashed = true;
        Score.isCrashed = true;

        SaveData.GetComponent<SavePlayersData>().analys();

        ButtonReset.SetActive(true);
        ButtonBackMenu.SetActive(true);
        ScoreText.SetActive(false);
        FTtext.text = Convert.ToString(scoreCount.GetComponent<Score>().score) + " m";
        RecordText.text = "Рекорд: " + Convert.ToString(SaveData.GetComponent<SavePlayersData>().record) + " m";
        FinalScore.SetActive(true);
        Record.SetActive(true);
    }
}
