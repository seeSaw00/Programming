using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Breakout
{
    public class Ball : MonoBehaviour
    {
        public float speed = 5f;
        private Vector3 velocity;

        private void Start()
        {
            Vector3 randDir = Random.onUnitSphere;
                    randDir.z = 0;
                    Fire(randDir);
        }

        public void Fire(Vector3 direction)
        {
            // Assign velocity as direction x speed
            velocity = direction * speed;
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            // grab the contact point of collision
            ContactPoint2D contact = collision.contacts[0];

            Vector3 reflect = Vector3.Reflect(velocity, contact.normal);
            velocity = reflect.normalized * speed;
        }

              
        // Update is called once per frame
        void Update()
        {
            transform.position += velocity * Time.deltaTime;
        }
    }
}