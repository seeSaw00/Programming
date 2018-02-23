using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Clean Code: CTRL + K + D (in that order)

// {} - Braces
// [] - Brackets
// () - Parenthesis
namespace Asteroids
{
    public class Moving : MonoBehaviour
    {

        // Member Variables
        public float rotationSpeed = 360;
        public float movementSpeed = 10;

        void Movement()
        {
            //Move up
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //Move the player up by movementSpeed
                //Vector3 position = transform.position;
                //position.y += movementSpeed * Time.deltaTime;
                //transform.position = position;
                transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
            }

            // Move down
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
            }
        }

        void Rotation()
        {
            // Rotate right
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
            }

            // Rotate left
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            }
        }
        // Update is called once per frame
        void Update()
        {
            //Call 'Movement()' function
            Movement();

            // Call 'Rotation()' function
            Rotation();


        }
    }
}
