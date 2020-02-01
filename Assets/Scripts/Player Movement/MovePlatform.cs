using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public GameObject platform;

    public float moveSpeed;

    public Transform currentPoint;

    public Transform[] points;

    public int pointSelection;

    public bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        currentPoint = points[pointSelection];
        
    }

    // Update is called once per frame
    void Update()
    {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position, currentPoint.position, Time.deltaTime *moveSpeed);

        if (platform.transform.position == currentPoint.position && isOn == true)
        {
            pointSelection++;

            if (pointSelection == points.Length)
            {
                pointSelection = 0;
                isOn = false;

            }

            currentPoint = points[pointSelection];
            isOn = false;

        }
    }
}
