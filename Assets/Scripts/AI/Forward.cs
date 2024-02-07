using UnityEngine;

namespace Gilbo
{


    public class Forward : MonoBehaviour
    {
        public Rigidbody rb;
        public float speed;
        public GilboEyes eyes;


        public void FixedUpdate()
        {
            
            rb.AddForce(transform.forward * speed);

        }


       
    }
}

