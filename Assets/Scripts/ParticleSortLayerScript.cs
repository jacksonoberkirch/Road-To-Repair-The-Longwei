using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ParticleSortLayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //Change Top to the layer you want it to display on 
        // could prob. make a public variable for this
        GetComponent<Renderer>().sortingLayerName = "Top";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
