﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI text;

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }

    // Updatinamas tekstas kai paimamas coin
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "x" + score.ToString();
    }

    public void MinusScore(int coinValue)
    {
        score -= coinValue;
        text.text = "x" + score.ToString();
    }

}
