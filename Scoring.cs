using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class Scoring : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    GameObject[] scoreBoardUI ;
    public VirtualButtonBehaviour Vb;   
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //gameObject.GetComponent().enabled = true;

        scoreBoardUI = GameObject.FindGameObjectsWithTag("ScoreCanvas");

        scoreText = gameObject.GetComponent<TextMeshProUGUI>();
        
      
        //scoreText.text = "Score: " + scoreText.ToString();       
    }
    // Update is called once per frame
    void Update()
    {
        score += +5;

        scoreText.text = "Score" + score.ToString();

    }
}
