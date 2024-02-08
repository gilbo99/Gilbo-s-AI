using UnityEngine;

namespace Gilbo
{
    public class Avoid : MonoBehaviour
    {
        [SerializeField]
        public Rigidbody rb;
        public float turnForce;
        public GilboEyes eyes;
        public float threshold;
        public float strength;
        

        public void Update()
        {
            if (eyes.distanceToObj < threshold)
            {
                turn();
            }
        }

        public void turn()
        {
           // var turnSpeed =  / eyes.distanceToObj;
           var angle = Vector3.SignedAngle(transform.forward, eyes.closestAngle, Vector3.up);
           rb.AddRelativeTorque(0,-angle ,0 * strength);
        }

        
    }
}
