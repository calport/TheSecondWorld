using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChangeLavaRoom : MonoBehaviour
{
    //This is a sample script of what how you could change your videos 
    public GameObject StateA, StateB, StateC;
    
   
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeIt", 10);
    }

    public void ChangeIt()
    {
        ServiceLocator._videoManager.ChangeVideoOfRoom(StateA,StateB,StateC); 
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
