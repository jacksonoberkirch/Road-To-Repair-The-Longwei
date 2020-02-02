using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroTrans : MonoBehaviour
{
    public Image globalGameJam;

    // Update is called once per frame
    void Start()
    {
        globalGameJam.canvasRenderer.SetAlpha(1.0f);
        fadeOut();

    }
   
     void fadeOut()
    {
        globalGameJam.CrossFadeAlpha(0, 5, true);
        
    }
    void disableImg() {
        globalGameJam.enabled = false;
    }
    
}
