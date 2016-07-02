using UnityEngine;
using System.Collections;

public class GameMove : MonoBehaviour
{

    public TweenPosition helpPosition;
    public TweenPosition returnPosition;


    public void OnClickButton()
    {
        helpPosition.PlayForward();
        returnPosition.PlayForward();
    }

    public void OnReturnButton()
    {
        helpPosition.PlayReverse();
        returnPosition.PlayReverse();
    }
}
