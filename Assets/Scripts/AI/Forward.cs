using UnityEngine;

namespace Gilbo
{


    public class Forward : MonoBehaviour
    {
        public Rigidbody rb;
        public float speed;
       
        public float threshold;

        private GilboEyes eyes;
        public void Start()
        {
            eyes = GetComponent<GilboEyes>();
        }
        public void FixedUpdate()
        {
            rb.AddForce(transform.forward * speed);
            
            /*
            if (eyes.distance > threshold )
            {
                
                rb.AddForce(transform.forward * speed);
            }
            else
            {
                rb.AddForce(-transform.forward * speed / eyes.distance);
            }
            */
            
            
            
            
            

        }
        


       
    }
}

