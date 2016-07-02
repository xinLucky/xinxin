using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MinBallScore : MonoBehaviour
{

    public UILabel scoreText;
    private int score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BallAddScore(int addscore)
    {
        score += addscore;
        scoreText.text = score.ToString();

    }
}
