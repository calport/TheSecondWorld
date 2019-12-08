using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChangeLavaRoom : MonoBehaviour
{
    //This is a sample script of what how you could change your videos 
    public GameObject _videoManager; 
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            _videoManager.GetComponent<VideoManager>().PoolRoomAvailablity();
           
            
            Debug.Log("checking room available");
        }
    }
}
