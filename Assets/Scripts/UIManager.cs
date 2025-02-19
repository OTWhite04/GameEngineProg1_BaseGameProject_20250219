using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //int for the score and reference for the TextMeshPro.
    public int score;

    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    //Method for increasing the score by 20 after pushing the button.
    public void ScoreUp()
    {
        score += 20;
        UpdateScoreUI();
    }

    //Method for decreasing the score by 20 after pushing a button.
    public void ScoreDown()
    {
        score -= 20;
        UpdateScoreUI();
    }

    //Resets the score after pushing a button.
    public void ScoreReset()
    {
        score = 0;
        UpdateScoreUI();
    }

    //Method for updating the score UI.
    public void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
    }

}

