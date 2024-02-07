using UnityEngine;

namespace Gilbo
{
    public class Avoid : MonoBehaviour
    {
        [SerializeField]
        public Rigidbody rb;
        public float turnForce;
        public GilboEyes eyes;
        

        public void Update()
        {
            if (eyes.distanceToObj < .5f)
            {
                turn();
            }
           
        }

        public void turn()
        {
            float turnSpeed = turnForce / eyes.distanceToObj;
            rb.AddRelativeTorque(0,turnSpeed ,0);
        }

        
    }
}
