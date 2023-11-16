using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private GameManager gameManager;
	private Text scoreText;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		scoreText = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + gameManager.score.ToString();
	}
}
