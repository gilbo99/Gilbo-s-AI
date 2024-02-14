using System;
using UnityEngine;

namespace Gilbo
{
    public class Avoid : MonoBehaviour
    {
        [SerializeField]
        public Rigidbody rb;
        public float turnForce;
        public float threshold;
        public float strength;
        [SerializeField]
        private float distance;
        
        private GilboEyes eyes;
        public void Start()
        {
            eyes = GetComponent<GilboEyes>();
        }
       

        public void Update()
        {

            if (eyes.distance < threshold)
            {
                turn();   
            }
        }

        private void turn()
        {
           // var turnSpeed =  / eyes.distanceToObj;
           var angle = Vector3.SignedAngle(transform.forward, eyes.closestAngle, Vector3.up);
           rb.AddRelativeTorque(0,turnForce * -angle * strength,0 );
        }
    
        
    }
}
