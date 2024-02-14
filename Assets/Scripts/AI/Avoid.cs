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
           var angle = Vector3.SignedAngle(transform.forward, eyes.closestAngle.normalized, Vector3.up);
           rb.AddRelativeTorque(0, (-angle * strength) / eyes.distance,0 );
           
        }
    
        
    }
}
