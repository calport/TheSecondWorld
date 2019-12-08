using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public GameObject[] VideoPlanes;

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

    public void ChangeVideoOfRoom(GameObject StateA,GameObject StateB,GameObject StateC)
    {
        // She wants her videos to changed based off the order players has visited previous rooms
        // maybe there should be States to determine which rooms are still accessible? 
        
    }
  
}
