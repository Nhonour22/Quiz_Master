using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndScreen : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI finalScoreText;
    Score_Keeper scoreKeeper;
    void Start()
    {
        scoreKeeper = FindObjectOfType<Score_Keeper>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "Congratulations!\nYou got a score of" +
                                 scoreKeeper.CalculateScore() + "%";
    }

    
}
