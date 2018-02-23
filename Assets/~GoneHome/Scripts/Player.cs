using UnityEngine;

namespace GoneHome
{
    public class Player : MonoBehaviour
    {

        public float movementSpeed = 10f;

        private Rigidbody rigid;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            
            // Get input axis
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            // Create a directional vector with input
        
            Vector3 inputDir = new Vector3(inputH, 0, inputV);

           
            // copy position
            Vector3 position = transform.position;
            // modifiy position 
            position += inputDir * movementSpeed * Time.deltaTime;
            // Apply to rigidbody
            rigid.MovePosition(position);
        }
    }
}