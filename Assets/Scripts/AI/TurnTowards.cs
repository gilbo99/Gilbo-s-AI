using UnityEngine;

namespace Gilbo
{
    public class TurnTowards : MonoBehaviour
    {
        private Vector3 targetpos;
        public Transform target;
        [SerializeField]
        private Rigidbody rb;
        public float turnSpeed;
        public float strength;
        public float angle;
        public void FixedUpdate()
        {
            Vector3 targetdir;
            if (target)
            {
                targetdir = target.position - transform.position;
                angle = Vector3.SignedAngle(transform.forward, targetdir, Vector3.up);
                var speed = angle / turnSpeed;
                rb.AddRelativeTorque(0,speed * strength,0);
            }
            else
            {
                targetdir = targetpos -= transform.position;
                angle = Vector3.SignedAngle(transform.forward, targetdir, Vector3.up);
                
                rb.AddRelativeTorque(0,angle * strength,0);
            }
            

        }
    }
}

