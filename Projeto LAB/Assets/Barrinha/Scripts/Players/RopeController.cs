using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeController : MonoBehaviour
{
    [SerializeField] LineRenderer line;
    [SerializeField] Transform[] playersPoints;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        line.positionCount = playersPoints.Length;
        for(int i = 0; i < playersPoints.Length; i++)
        {
            line.SetPosition(i, playersPoints[i].position);
        }
    }
}
