using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class Player : MonoBehaviour
    {

        public float acceleration = 10f;
        public float maxVelocity = 20f;

        private Rigidbody rigid;

        private Vector3 spawnPoint; 

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
            spawnPoint = transform.position; //store starting pos
        }

        // Update is called once per frame
        void Update()
        {
            
            // Get input axis
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            // Create a directional vector with input
        
            Vector3 inputDir = new Vector3(inputH, 0, inputV);

            //Depending on rotation of camera, change direction of input
            inputDir = Quaternion.AngleAxis(Camera.main.transform.eulerAngles.y, Vector3.up) * inputDir;

            rigid.AddForce(inputDir * acceleration);

            // check if out velocity goes over maxVelocity
            if (rigid.velocity.magnitude > maxVelocity)
            {

                //cap the velocity down to max
                rigid.velocity = rigid.velocity.normalized * maxVelocity;
            }
        }
        public void Reset()
        {

            //reset position back to spawn point
            transform.position = spawnPoint;

            //reset the player's velocity
            rigid.velocity = Vector3.zero;
        }
    }
}