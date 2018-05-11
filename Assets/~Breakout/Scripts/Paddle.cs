using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Breakout
{
    public class Paddle : MonoBehaviour
    {
        public float movementSpeed = 10;
        public Ball currentBall;
        public Vector3[] directions =
            {
        new Vector2(-.5f, .5f),
        new Vector2(.5f, .5f)
    };
        // Use this for initialization
        void Start()
        {

        }
        void Fire()
        {
            // disown our child (ball)
            currentBall.transform.SetParent(null);
            //Select random dir
            Vector3 randomDir = directions[Random.Range(0, directions.Length)];
            // Fire off ball in randomDirection
            currentBall.Fire(randomDir);

        }


        void CheckInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Fire();
            }
        }

        void Movement()
        {
            float inputH = Input.GetAxis("Horizontal");
            Vector3 force = transform.right * inputH;
            force *= movementSpeed;
            force *= Time.deltaTime;
            transform.position += force;
        }
        // Update is called once per frame
        void Update()
        {
            CheckInput();
            Movement();
        }
    }


}