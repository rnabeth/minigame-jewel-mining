﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	public int score = 0;
	public int targetScore = 400;
	public Text scoreText;
	public Text timeText;
	public int timePerLevel = 30;
	public GameObject youWon;
	public GameObject gameOver;

	private float clockSpeed = 1f;

	void Awake()
	{
		scoreText.text = "Score: " + score + "/" + targetScore;

		InvokeRepeating("Clock", 0, clockSpeed);
	}

	void Clock()
	{
		timePerLevel--;
		timeText.text = "Time: " + timePerLevel;

		if (timePerLevel == 0)
		{
			CheckGameOver();
		}
	}

	void CheckGameOver()
	{
		if (score >= targetScore)
		{
			Time.timeScale = 0;
			youWon.SetActive(true);
		}
		else
		{
			Time.timeScale = 0;
			gameOver.SetActive(true);
		}
	}

	public void AddPoints(int pointScored)
	{
		score += pointScored;
		scoreText.text = "Score: " + score + "/" + targetScore;
	}
}
