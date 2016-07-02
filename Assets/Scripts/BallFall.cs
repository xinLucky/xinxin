using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallFall : MonoBehaviour
{
    public RandomCreate rc;
    public MinBallScore mbs;

    public GameObject BaoZa;

    void Start()
    {
        rc = GameObject.Find("Ball_Create").GetComponent<RandomCreate>();
        mbs = GameObject.Find("UI Root/score").GetComponent<MinBallScore>();
    }


    public void OnMouseDown()
    {
        if (0.5f < rc.size  && rc.size < 1f)
        {
            mbs.BallAddScore(1);
        }
        if (1f < rc.size && rc.size < 1.5f)
        {
            mbs.BallAddScore(2);
        }
        if (1.5f < rc.size && rc.size < 2f)
        {
            mbs.BallAddScore(3);
        }
        if (2f < rc.size && rc.size < 2.5f )
        {
            mbs.BallAddScore(4);
        }
        if (2.5f < rc.size && rc.size < 3f)
        {
            mbs.BallAddScore(5);
        }
  
        transform.DetachChildren();
        rc.ballList.Remove(rc.ball);
        Instantiate(BaoZa, transform.position, Quaternion.identity);
        Destroy(gameObject);
        
    }

    void Update()
    {
        if (transform.position.y < -20.5f)
        {
            transform.DetachChildren();
            Destroy(this.gameObject);
           
            //ObjectPool.instance.Return(this.gameObject);
        }
    }
}
