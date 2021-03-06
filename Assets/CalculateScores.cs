﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalculateScores : MonoBehaviour {
    [SerializeField]
    private TextMeshProUGUI previousScoreText, bananaText, livesText, scoreText;
    [SerializeField]
    private float bananaScore, liveScore;

	// Use this for initialization
	void Start () {
        GameManager.instance.DisableGameUI();
        calculateScoreTexts();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void calculateScoreTexts()
    {
        bananaText.text = "Bananas: " + GameManager.instance.bananas + " X " + bananaScore + " = " + (bananaScore * GameManager.instance.bananas);
        scoreText.text = "" + (/*(GameManager.instance.collectibles * collectibleScore)*/ + (GameManager.instance.bananas * bananaScore));
    }
}
