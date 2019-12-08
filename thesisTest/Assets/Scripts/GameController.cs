using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //This script is used to start the Service Locator 
    void Start()
    {
        _InitializeServices(); 
    }

    public void _InitializeServices()
    {
        ServiceLocator._gameController = this;
        ServiceLocator._videoManager = gameObject.GetComponent<VideoManager>();
        
    }
}
