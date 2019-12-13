using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public GameObject[] VideoPlanes;

    public TunnelOfLoveRoom currentTunnelOfLoveRoomState;
    public SnowRoom currentSnowRoomState;
    public TheatreOutRoom currentTheatreOutState;
    public FarmRoom currentFarmRoomState;
    public SlotRoom currentSlotRoomState;
    public PoolRoom currentPoolRoomState;
    public StairRoom currentStairRoomState;
    public BarRoom currentBarRoomState;
    public TheatreInRoom currentTheatreInState;
    public BedRoom currentBedRoomState; 
    

    #region AllRoomStates
    
//these are all available states per each of your rooms 
    public enum TunnelOfLoveRoom
    {
        VideoA, 
        VideoB, 
        idleVideo,
        isFinished
    }
    
    public enum SnowRoom
    {
        VideoA, 
        VideoB, 
        idleVideo,
        isFinished
    }
    
    public enum TheatreOutRoom
    {
        VideoA, 
        VideoB, 
        idleVideo,
        isFinished
    }
    
    public enum FarmRoom
    {
        VideoA, 
        VideoB, 
        idleVideo,
        isFinished
    }
    
    public enum SlotRoom
    {
        VideoA, 
        VideoB, 
        idleVideo,
        isFinished
    }
    
    public enum PoolRoom
    {
        VideoA, 
        VideoB,
        idleVideo,
        isFinished,
    }
    
    public enum StairRoom
    {
        VideoA, 
        VideoB,
        idleVideo,
        isFinished,
    }
    
    public enum BarRoom
    {
        VideoA, 
        VideoB,
        idleVideo,
        isFinished,
    }
    
    public enum TheatreInRoom
    {
        VideoA, 
        VideoB,
        idleVideo,
        isFinished,
    }
    
    public enum BedRoom
    {
        VideoA, 
        VideoB,
        idleVideo,
        isFinished,
    }
    
    #endregion
    
    

    void Awake()
    {
        //this is Preparing your videos for the game 
        //by preloading them all so you will not have buffer problems
        PreLoadVideos();
    }

    public void Start()
    {
        SetStartingVideoStates();
    }

    private void SetStartingVideoStates() //a function to set all starting videos States to where you want them at the start of the game
    {
        currentTunnelOfLoveRoomState = TunnelOfLoveRoom.idleVideo;
        currentSnowRoomState = SnowRoom.idleVideo;
        currentTheatreOutState = TheatreOutRoom.idleVideo;
        currentFarmRoomState = FarmRoom.idleVideo;
        currentPoolRoomState = PoolRoom.idleVideo;
        currentStairRoomState = StairRoom.idleVideo;
        currentBarRoomState = BarRoom.idleVideo;
        currentTheatreInState = TheatreInRoom.idleVideo;
        currentBedRoomState = BedRoom.idleVideo; 
    }

    public void Update()
    {
        switch (currentTunnelOfLoveRoomState)
        {
            case TunnelOfLoveRoom.VideoA:
                VideoPlanes[0].SetActive(true);
                VideoPlanes[1].SetActive(false);
                VideoPlanes[2].SetActive(false);
                break;
            case TunnelOfLoveRoom.VideoB:
                VideoPlanes[0].SetActive(false);
                VideoPlanes[1].SetActive(true);
                VideoPlanes[2].SetActive(false);
                break;
            case TunnelOfLoveRoom.idleVideo:
                VideoPlanes[0].SetActive(false);
                VideoPlanes[1].SetActive(false);
                VideoPlanes[2].SetActive(true);
                break;
            case TunnelOfLoveRoom.isFinished:
                VideoPlanes[0].SetActive(false);
                VideoPlanes[1].SetActive(false);
                VideoPlanes[2].SetActive(false);
                break;
            default:
                break;
        }
        switch (currentSnowRoomState)
        {
            case SnowRoom.VideoA:
                VideoPlanes[3].SetActive(true);
                VideoPlanes[4].SetActive(false);
                VideoPlanes[5].SetActive(false);
                break;
            case SnowRoom.VideoB:
                VideoPlanes[3].SetActive(false);
                VideoPlanes[4].SetActive(true);
                VideoPlanes[5].SetActive(false);
                break;
            case SnowRoom.idleVideo:
                VideoPlanes[3].SetActive(false);
                VideoPlanes[4].SetActive(false);
                VideoPlanes[5].SetActive(true);
                break;
            case SnowRoom.isFinished:
                VideoPlanes[3].SetActive(false);
                VideoPlanes[4].SetActive(false);
                VideoPlanes[5].SetActive(false);
                break;
            default:
                break;
        }
        switch (currentTheatreOutState)
        {
            case TheatreOutRoom.VideoA:
                VideoPlanes[6].SetActive(true);
                VideoPlanes[7].SetActive(false);
                VideoPlanes[8].SetActive(false);
                break;
            case TheatreOutRoom.VideoB:
                VideoPlanes[6].SetActive(false);
                VideoPlanes[7].SetActive(true);
                VideoPlanes[8].SetActive(false);
                break;
            case TheatreOutRoom.idleVideo:
                VideoPlanes[6].SetActive(false);
                VideoPlanes[7].SetActive(false);
                VideoPlanes[8].SetActive(true);
                break;
            case TheatreOutRoom.isFinished:
                VideoPlanes[6].SetActive(false);
                VideoPlanes[7].SetActive(false);
                VideoPlanes[8].SetActive(false);
                break;
            default:
                break;
        }
        switch (currentFarmRoomState)
        {
            case FarmRoom.VideoA:
                VideoPlanes[9].SetActive(true);
                VideoPlanes[10].SetActive(false);
                VideoPlanes[11].SetActive(false);
                break;
            case FarmRoom.VideoB:
                VideoPlanes[9].SetActive(false);
                VideoPlanes[10].SetActive(true);
                VideoPlanes[11].SetActive(false);
                break;
            case FarmRoom.idleVideo:
                VideoPlanes[9].SetActive(false);
                VideoPlanes[10].SetActive(false);
                VideoPlanes[11].SetActive(true);
                break;
            case FarmRoom.isFinished:
                VideoPlanes[9].SetActive(false);
                VideoPlanes[10].SetActive(false);
                VideoPlanes[11].SetActive(false);
                break;
            default:
                break;
        }
        switch (currentSlotRoomState)
        {
            case SlotRoom.VideoA:
                VideoPlanes[12].SetActive(true);
                VideoPlanes[13].SetActive(false);
                VideoPlanes[14].SetActive(false);
                break;
            case SlotRoom.VideoB:
                VideoPlanes[12].SetActive(false);
                VideoPlanes[13].SetActive(true);
                VideoPlanes[14].SetActive(false);
                break;
            case SlotRoom.idleVideo:
                VideoPlanes[12].SetActive(false);
                VideoPlanes[13].SetActive(false);
                VideoPlanes[14].SetActive(true);
                break;
            case SlotRoom.isFinished:
                VideoPlanes[12].SetActive(false);
                VideoPlanes[13].SetActive(false);
                VideoPlanes[14].SetActive(false);
                break;
            default:
                break;
        }
        switch (currentPoolRoomState)
        {
            case PoolRoom.VideoA:
                VideoPlanes[15].SetActive(true);
                VideoPlanes[16].SetActive(false);
                VideoPlanes[17].SetActive(false);
                break;
            case PoolRoom.VideoB:
                VideoPlanes[15].SetActive(false);
                VideoPlanes[16].SetActive(true);
                VideoPlanes[17].SetActive(false);
                break;
            case PoolRoom.idleVideo:
                VideoPlanes[15].SetActive(false);
                VideoPlanes[16].SetActive(false);
                VideoPlanes[17].SetActive(true);
                break;
            case PoolRoom.isFinished:
                VideoPlanes[15].SetActive(false);
                VideoPlanes[16].SetActive(false);
                VideoPlanes[17].SetActive(false);
                break;
            default:
                break;
        }
        switch (currentStairRoomState)
        {
            case StairRoom.VideoA:
                VideoPlanes[18].SetActive(true);
                VideoPlanes[19].SetActive(false);
                VideoPlanes[20].SetActive(false);
                break;
            case StairRoom.VideoB:
                VideoPlanes[18].SetActive(false);
                VideoPlanes[19].SetActive(true);
                VideoPlanes[20].SetActive(false);
                break;
            case StairRoom.idleVideo:
                VideoPlanes[18].SetActive(false);
                VideoPlanes[19].SetActive(false);
                VideoPlanes[20].SetActive(true);
                break;
            case StairRoom.isFinished:
                VideoPlanes[18].SetActive(false);
                VideoPlanes[19].SetActive(false);
                VideoPlanes[20].SetActive(false);
                break;
            default:
                break;
        }
        switch (currentTheatreInState)
        {
            case TheatreInRoom.VideoA:
                VideoPlanes[21].SetActive(true);
                VideoPlanes[22].SetActive(false);
                VideoPlanes[23].SetActive(false);
                break;
            case TheatreInRoom.VideoB:
                VideoPlanes[21].SetActive(false);
                VideoPlanes[22].SetActive(true);
                VideoPlanes[23].SetActive(false);
                break;
            case TheatreInRoom.idleVideo:
                VideoPlanes[21].SetActive(false);
                VideoPlanes[22].SetActive(false);
                VideoPlanes[23].SetActive(true);
                break;
            case TheatreInRoom.isFinished:
                VideoPlanes[21].SetActive(false);
                VideoPlanes[22].SetActive(false);
                VideoPlanes[23].SetActive(false);
                break;
            default:
                break;
        }
        switch (currentBedRoomState)
        {
            case BedRoom.VideoA:
                VideoPlanes[24].SetActive(true);
                VideoPlanes[25].SetActive(false);
                VideoPlanes[26].SetActive(false);
                break;
            case BedRoom.VideoB:
                VideoPlanes[24].SetActive(false);
                VideoPlanes[25].SetActive(true);
                VideoPlanes[26].SetActive(false);
                break;
            case BedRoom.idleVideo:
                VideoPlanes[24].SetActive(false);
                VideoPlanes[25].SetActive(false);
                VideoPlanes[26].SetActive(true);
                break;
            case BedRoom.isFinished:
                VideoPlanes[24].SetActive(false);
                VideoPlanes[25].SetActive(false);
                VideoPlanes[26].SetActive(false);
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

    
    //can it I make a generic one that you pass information too? 
    //you cant pass an enum. 
    /*
    public void CheckAvailability(GameObject RoomA, GameObject RoomB, )
    {
        if (ServiceLocator.TunnelRoomA && ServiceLocator.TunnelRoomB && ServiceLocator.TunnelIdle)
            currentTunnelOfLoveRoomState = TunnelOfLoveRoom.VideoA; 
        else if (!ServiceLocator.TunnelRoomA && ServiceLocator.TunnelRoomB) 
            currentTunnelOfLoveRoomState = TunnelOfLoveRoom.VideoB;
        else if (ServiceLocator.TunnelRoomA && !ServiceLocator.TunnelRoomB) 
            currentTunnelOfLoveRoomState = TunnelOfLoveRoom.VideoA;
        else  currentTunnelOfLoveRoomState = TunnelOfLoveRoom.idleVideo;
    } */

    public void TunnelOfLoveAvailability() //this function see's what options are available in Tunnel of Love 
    {
        if (ServiceLocator.TunnelRoomA && ServiceLocator.TunnelRoomB && ServiceLocator.TunnelIdle)
            currentTunnelOfLoveRoomState = TunnelOfLoveRoom.VideoA; 
        else if (!ServiceLocator.TunnelRoomA && ServiceLocator.TunnelRoomB) 
            currentTunnelOfLoveRoomState = TunnelOfLoveRoom.VideoB;
        else if (ServiceLocator.TunnelRoomA && !ServiceLocator.TunnelRoomB) 
            currentTunnelOfLoveRoomState = TunnelOfLoveRoom.VideoA;
        else  currentTunnelOfLoveRoomState = TunnelOfLoveRoom.idleVideo;
    }
    
    public void SnowRoomAvailability() //this function see's what options are available in SnowRoom 
    {
        if (ServiceLocator.SnowRoomA && ServiceLocator.SnowRoomB && ServiceLocator.SnowRoomIdle)
            currentSnowRoomState = SnowRoom.VideoA; 
        else if (!ServiceLocator.SnowRoomA && ServiceLocator.SnowRoomB) 
            currentSnowRoomState = SnowRoom.VideoB;
        else if (ServiceLocator.SnowRoomA && !ServiceLocator.SnowRoomB) 
            currentSnowRoomState = SnowRoom.VideoA;
        else  currentSnowRoomState = SnowRoom.idleVideo;
    }

    public void TheatreOutRoomAvailability() //this function see's what options are available in TheatreOutRoom 
    {
        if (ServiceLocator.TheatreOutRoomA && ServiceLocator.TheatreOutRoomB && ServiceLocator.TheatreOutIdle)
            currentTheatreOutState = TheatreOutRoom.VideoA; 
        else if (!ServiceLocator.TheatreOutRoomA && ServiceLocator.TheatreOutRoomB) 
            currentTheatreOutState = TheatreOutRoom.VideoB;
        else if (ServiceLocator.TheatreOutRoomA && !ServiceLocator.TheatreOutRoomB) 
            currentTheatreOutState = TheatreOutRoom.VideoA;
        else  currentTheatreOutState = TheatreOutRoom.idleVideo;
    }
    
    public void FarmRoomAvailablity() //this function see's what options are available in FarmRoom 
    {
        if (ServiceLocator.FarmRoomA && ServiceLocator.FarmRoomB && ServiceLocator.FarmIdle)
            currentFarmRoomState = FarmRoom.VideoA; 
        else if (!ServiceLocator.FarmRoomA && ServiceLocator.FarmRoomB) 
            currentFarmRoomState = FarmRoom.VideoB;
        else if (ServiceLocator.FarmRoomA && !ServiceLocator.FarmRoomB) 
            currentFarmRoomState = FarmRoom.VideoA;
        else  currentFarmRoomState = FarmRoom.idleVideo;
    }
    
    public void SlotRoomAvailablity() //this function see's what options are available in SlotRoom 
    {
        if (ServiceLocator.SlotRoomA && ServiceLocator.SlotRoomB && ServiceLocator.SlotIdle)
            currentSlotRoomState = SlotRoom.VideoA; 
        else if (!ServiceLocator.SlotRoomA && ServiceLocator.SlotRoomB) 
            currentSlotRoomState = SlotRoom.VideoB;
        else if (ServiceLocator.SlotRoomA && !ServiceLocator.SlotRoomB) 
            currentSlotRoomState = SlotRoom.VideoA;
        else  currentSlotRoomState = SlotRoom.idleVideo;
    }
    
    public void PoolRoomAvailablity() //this function see's what options are available in PoolRoom 
    {
        if (ServiceLocator.PoolRoomA && ServiceLocator.PoolRoomB && ServiceLocator.PoolIdle)
            currentPoolRoomState = PoolRoom.VideoA; 
        else if (!ServiceLocator.PoolRoomA && ServiceLocator.PoolRoomB) 
            currentPoolRoomState = PoolRoom.VideoB;
        else if (ServiceLocator.PoolRoomA && !ServiceLocator.PoolRoomB) 
            currentPoolRoomState = PoolRoom.VideoA;
        else  currentPoolRoomState = PoolRoom.idleVideo;
    }
    
    public void StairRoomAvailability() //this function see's what options are available in StairRoom 
    {
        if (ServiceLocator.StairRoomA && ServiceLocator.StairRoomB && ServiceLocator.StairIdle)
            currentStairRoomState = StairRoom.VideoA; 
        else if (!ServiceLocator.StairRoomA && ServiceLocator.StairRoomB) 
            currentStairRoomState = StairRoom.VideoB;
        else if (ServiceLocator.StairRoomA && !ServiceLocator.StairRoomB) 
            currentStairRoomState = StairRoom.VideoA;
        else  currentStairRoomState = StairRoom.idleVideo;
    }
    
    public void BarRoomAvailability() //this function see's what options are available in BarRoom 
    {
        if (ServiceLocator.BarRoomA && ServiceLocator.BarRoomB && ServiceLocator.BarRoomIdle)
            currentBarRoomState = BarRoom.VideoA; 
        else if (!ServiceLocator.BarRoomA && ServiceLocator.BarRoomB) 
            currentBarRoomState = BarRoom.VideoB;
        else if (ServiceLocator.BarRoomA && !ServiceLocator.BarRoomB) 
            currentBarRoomState = BarRoom.VideoA;
        else  currentBarRoomState = BarRoom.idleVideo;
    }

    public void TheatreInRoomAvailability() //this function see's what options are available in TheatreInRoom 
    {
        if (ServiceLocator.TheatreInRoomA && ServiceLocator.TheatreInRoomB && ServiceLocator.TheatreInIdle)
            currentTheatreInState = TheatreInRoom.VideoA; 
        else if (!ServiceLocator.TheatreInRoomA && ServiceLocator.TheatreInRoomB) 
            currentTheatreInState = TheatreInRoom.VideoB;
        else if (ServiceLocator.TheatreInRoomA && !ServiceLocator.TheatreInRoomB) 
            currentTheatreInState = TheatreInRoom.VideoA;
        else  currentTheatreInState = TheatreInRoom.idleVideo;
    }
    
    public void BedRoomAvailability() //this function see's what options are available in BedRoom 
    {
        if (ServiceLocator.BedRoomA && ServiceLocator.BedRoomB && ServiceLocator.BedRoomIdle)
            currentBedRoomState = BedRoom.VideoA; 
        else if (!ServiceLocator.BedRoomA && ServiceLocator.BedRoomB) 
            currentBedRoomState = BedRoom.VideoB;
        else if (ServiceLocator.BedRoomA && !ServiceLocator.BedRoomB) 
            currentBedRoomState = BedRoom.VideoA;
        else  currentBedRoomState = BedRoom.idleVideo;
    }

  
}
