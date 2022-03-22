using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quiz_1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionsSO question;
    [SerializeField] GameObject[] answerButtons;
    async void Start()
    {
        questionText.text = question.GetQuestion();

        for(int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        } 
        
        
    }


    
}
