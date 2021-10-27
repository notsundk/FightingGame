using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameInformation : MonoBehaviour
{
    // Singleton
    public static GameInformation instance;

    private void Awake()
    {
        instance = this;
    
        // Time Limit
        // Health
    }

    [SerializeField] TMP_Text ui_ScoreText;

    int playerScore = 0;

    public void Update_PlayerScore(int amountToUpdate)
    {
        playerScore += amountToUpdate;                  // New Amount
        ui_ScoreText.text = "Score : " + playerScore;   // Update
        //ui_ScoreText.text = "" + playerScore;         // Update (Convert to String)
    }

    public void Reset_PlayerScore()
    {
        playerScore = 0;                                // New Amount
        ui_ScoreText.text = "Score : " + playerScore;   // Update
    }
}
