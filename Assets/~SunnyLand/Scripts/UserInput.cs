using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunnyLand
{
    // Force Unity to attach "PlayerController"
    [RequireComponent(typeof(PlayerController))]
    public class UserInput : MonoBehaviour
    {
        public bool isJumping = false;
        public bool isCrouching = false;
        public float inputH, inputV;
        
        // Reference to player controller
        private PlayerController player;

        #region Unity Functions
        // Use this for initialization
        void Start()
        {
            player = GetComponent<PlayerController>();
        }

        // Update is called once per frame
        void Update()
        {
            // Update input
            GetInput();
            // Control the Player with input
            player.Move(inputH);
            player.Climb(inputV);
            if (isJumping)
            {
                player.Jump();
            }
            if(isCrouching)
            {
                player.Crouch();
                
            }
            else
            {
                player.UnCrouch();
            }
        }
        #endregion

        #region Custom Functions
        void GetInput()
        {
            inputH = Input.GetAxisRaw("Horizontal");
            inputV = Input.GetAxisRaw("Vertical");
            isJumping = Input.GetKeyDown(KeyCode.Space);
            isCrouching = Input.GetKey(KeyCode.LeftControl);
        }
        #endregion
    }
}