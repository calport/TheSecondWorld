using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatewater : MonoBehaviour
{

    private Transform WaterCube;
    
    // Start is called before the first frame update
    void Start()
    {
        WaterCube = GetComponent<Transform>();
        WaterCube.transform.Rotate(0, 0, -90, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
