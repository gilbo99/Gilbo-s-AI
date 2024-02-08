using UnityEngine;

namespace Gilbo
{


    public class Forward : MonoBehaviour
    {
        public Rigidbody rb;
        public float speed;
        public GilboEyes eyes;
        public float threshold;


        public void FixedUpdate()
        {
            if (eyes.distanceToObj < threshold )
            {
                rb.AddForce(transform.forward * speed);
                
            }
            else
            {
                rb.AddForce(-transform.forward * speed / eyes.distanceToObj);
            }
            

        }


       
    }
}

