using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;


[RequireComponent(typeof(CharacterController))]
public class input_movement : MonoBehaviour
{

    public int playerId = 0;
    public float moveSpeed = 3.0f;

    private Player player;
    private CharacterController cc;
    private Vector3 moveVector;

    void Awake()
    {
        // Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
        player = ReInput.players.GetPlayer(playerId);
        // Get the character controller
        cc = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        GetInput();
        ProcessInput();
    }

    private void GetInput()
    {
        // Get the input from the Rewired Player. All controllers that the Player owns will contribute, so it doesn't matter
        // whether the input is coming from a joystick, the keyboard, mouse, or a custom controller.

        moveVector.x = player.GetAxis("Move Horizontal");
    }

    private void ProcessInput()
    {
        // Process movement
        if (moveVector.x != 0.0f || moveVector.y != 0.0f)
        {
            cc.Move(moveVector * moveSpeed * Time.deltaTime);
        }
    }
}
