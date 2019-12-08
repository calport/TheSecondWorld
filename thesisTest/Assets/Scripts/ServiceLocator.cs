using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ServiceLocator
{
    //Getting a reference of all your game managers
    //you can use this script to get a reference of any of the managers you need
    //think of it as a phonebook  

    public static GameController _gameController; 
    public static VideoManager _videoManager; 
    

       #region RoomBools
       
       //Tunnel of Love Room Bools
       public static bool TunnelRoomA = true;
       public static bool TunnelRoomB = true;
       public static bool TunnelIdle = true; 
       
       //Snow Room Bools 
       public static bool SnowRoomA = true;
       public static bool SnowRoomB = true;
       public static bool SnowRoomIdle = true; 
       
       //Theatre Out Room Bools 
       public static bool TheatreOutRoomA = true;
       public static bool TheatreOutRoomB  = true;
       public static bool TheatreOutIdle = true; 
       
       //Farm Room Bools
       public static bool FarmRoomA = true;
       public static bool FarmRoomB = true;
       public static bool FarmIdle = true; 
       
       //Slot Room Bools 
       public static bool SlotRoomA  = true;
       public static bool SlotRoomB = true;
       public static bool SlotIdle = true;

       //Pool Room Bools 
        public static bool PoolRoomA = true;
        public static bool PoolRoomB = true;
        public static bool PoolIdle = true; 
        
        //Stair Room Bools 
        public static bool StairRoomA = true;
        public static bool StairRoomB = true;
        public static bool StairIdle = true; 
        
        //BarRoom Bools
        public static bool BarRoomA = true;
        public static bool BarRoomB = true;
        public static bool BarRoomIdle = true; 
        
        //Theatre In Bools
        public static bool TheatreInRoomA = true;
        public static bool TheatreInRoomB = true;
        public static bool TheatreInIdle = true; 
        
        //Bedroom Bools 
        public static bool BedRoomA = true;
        public static bool BedRoomB = true;
        public static bool BedRoomIdle = true; 

        #endregion

}
