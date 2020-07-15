using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{
    public Text mText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SplashScreen Start()");
    }


    public void SplashPlayEnd()
    {
        if(null != mText)
        {
            mText.text = "SplashPlayEnd";
        }
    }

}
