using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class RandomCreate : MonoBehaviour
{
    public UIButton button;
    public GameObject ballPrefab;
    public float xMan;
    public float xMin;

    public float zMan;
    public float ZMin;

    public float size;
    private float gameTime = 60;

    public UILabel timText;
    public GameObject ball;

    public List<GameObject> ballList;
    public GameObject BaoZa;
	// Use this for initialization
	void Start ()
	{
	    
        ballList = new List<GameObject>();
        StartCoroutine(BallCreate());
	}

    void Update()
    {
        gameTime -= Time.deltaTime;
        if (gameTime <= 0)
        {
            Time.timeScale = 0;
            button.gameObject.SetActive(true);
            gameTime = 0;
            StopAllCoroutines();
        }
        timText.text = gameTime.ToString();
    }

    IEnumerator BallCreate()
    {
        while (true)
        {
            ball = Instantiate(ballPrefab)as GameObject;
            ballList.Add(ball);
            ball.transform.position = new Vector3(Random.Range(xMin, xMan), 10, Random.Range(ZMin,zMan));
            size = Random.Range(1f, 3f);
            ball.transform.localScale = new Vector3(size,size,size);
            yield return new WaitForSeconds(0.5f); 
        }
    }

    public void CameraFollowBall()
    {
        while (true)
        {
            var ballIndex = Random.Range(0, ballList.Count - 1);
            if (ballList[ballIndex] != null)
            {
                Camera.main.transform.parent = ballList[ballIndex].transform;
                Camera.main.transform.localPosition = new Vector3(0, 0, -10);
                break;
            }
        }
    }



    public void BallClear()
    {
      
        if (ballList.Count != 0)
        {
            for (int i = 0; i < ballList.Count; i++)
            {
                if (ballList[i]!=null)
                {
                    Instantiate(BaoZa, ball.transform.position, Quaternion.identity);
                    ballList[i].transform.DetachChildren();
                    Destroy(ballList[i]);
                }
               
            } 
            ballList.Clear();
        }
        
    }
}
