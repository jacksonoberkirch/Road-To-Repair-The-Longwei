using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [SerializeField]
    GameObject switchs;

    [SerializeField]
    GameObject platform;

    void Update()
    {
    
        if (switchs.GetComponent<Switch>().isOn == true)
        {
            platform.GetComponent<MovePlatform>().isOn = true;
        }

    }



}
