
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public VirtualButtonBehaviour Vb;
    public static int score = 0;
 
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
    }

    // Update is called once per frame

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {


        score += 5;
       


    }

    void Update()
    {
        scoreText.text = score.ToString("0");




    }
}
