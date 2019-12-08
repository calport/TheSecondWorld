using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public GameObject[] VideoPlanes;
    public FireRoom currentFireRoomState;
    
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

    public void Start()
    {
        currentFireRoomState = FireRoom.idleVideo;
    }

    public void Update()
    {
        switch (currentFireRoomState)
        {
            case FireRoom.VideoA:
                VideoPlanes[0].SetActive(true);
                VideoPlanes[1].SetActive(false);
                VideoPlanes[2].SetActive(false);
                break;
            case FireRoom.VideoB:
                VideoPlanes[0].SetActive(false);
                VideoPlanes[1].SetActive(true);
                VideoPlanes[2].SetActive(false);
                break;
            case FireRoom.idleVideo:
                VideoPlanes[0].SetActive(false);
                VideoPlanes[1].SetActive(false);
                VideoPlanes[2].SetActive(true);
                break;
            case FireRoom.isFinished:
                VideoPlanes[0].SetActive(false);
                VideoPlanes[1].SetActive(false);
                VideoPlanes[2].SetActive(false);
                break;
            default:
                break;
        }
    }

    private void PreLoadVideos()
    {
        for (int i = 0; i >= VideoPlanes.Length; i++)
        {
            VideoPlanes[i].GetComponent<VideoPlayer>().Prepare();
        }
    }


    public void CheckFireRoomAvailablity() //this function see's what options are available 
    {
        var StateA = VideoPlanes[0];
        var StateB = VideoPlanes[1];
        var StateC = VideoPlanes[2]; 
        
        if (ServiceLocator.FireRoomA && ServiceLocator.FireRoomB && ServiceLocator.FireRoomC)
            currentFireRoomState = FireRoom.VideoA; 
        else if (!ServiceLocator.FireRoomA && ServiceLocator.FireRoomB) 
            currentFireRoomState = FireRoom.VideoB;
        else if (ServiceLocator.FireRoomA && !ServiceLocator.FireRoomB) 
            currentFireRoomState = FireRoom.VideoA;
        else  currentFireRoomState = FireRoom.idleVideo;
    }
  
}
