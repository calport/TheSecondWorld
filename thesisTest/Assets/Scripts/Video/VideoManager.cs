using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public GameObject[] VideoPlanes;
    
    // enum with ISFIREACCESSABLE FIRESIDEB-NOT FIRESIDEA_NOT
    public enum StairRoom
    {
        VideoA, 
        VideoB,
        idleVideo,
        isFinished,
    }
    
    public enum FireRoom
    {
        VideoA, 
        VideoB,
        idleVideo,
        isFinished,
    }

    void Awake()
    {
        //this is Preparing your videos for the game 
        //by preloading them all so you will not have buffer problems
        PreLoadVideos();
    }

    private void PreLoadVideos()
    {
        for (int i = 0; i >= VideoPlanes.Length; i++)
        {
            VideoPlanes[i].GetComponent<VideoPlayer>().Prepare();
        }
    }

    public void ChangeVideoOfRoom(string Room, GameObject StateA,GameObject StateB,GameObject StateC)
    {
        // She wants her videos to changed based off the order players has visited previous rooms
        // maybe there should be States to determine which rooms are still accessible?
        switch (Room)
        {
            case "FireRoom":
                //CheckFireRoomAvailablity(StateA, StateB, StateC); 
                
                break;
            case "StairRoom":
                break;
            default:
                break;
        }
        
    }

    public  CheckFireRoomAvailablity(GameObject StateA, GameObject StateB, GameObject StateC) //this function see's what options are available 
    {
        if (ServiceLocator.FireRoomA && ServiceLocator.FireRoomB && ServiceLocator.FireRoomC) return StateA; 
        else if (!ServiceLocator.FireRoomA && ServiceLocator.FireRoomB) return StateB; 
        else if (ServiceLocator.FireRoomA && !ServiceLocator.FireRoomB) return StateA;
        else return StateC; 
            
        
        return null; 
    }
  
}
