using UnityEngine;

namespace Gilbo
{
    public class Pursuit : MonoBehaviour
    {
        public float strength;
        public Transform pursuitTarget;

        public float offset;
        
        private GilboEyes eyes;
        private Neighbours neighbours;
        private Rigidbody rb;


        public Vector3 draw;
        public void Start()
        {
            eyes = GetComponent<GilboEyes>();
            rb = GetComponent<Rigidbody>();
            neighbours = GetComponent<Neighbours>();
        }

        public void FixedUpdate()
        {
            
            Vector3 target = CalculateNeighbours(pursuitTarget);
            if (target != Vector3.zero)
            {
                draw = target;
                Vector3 targetdir = target - transform.position;
                float angle = Vector3.SignedAngle(transform.forward, targetdir, Vector3.up);
                rb.AddTorque(0,angle * strength,0, ForceMode.Acceleration);
            }
        }

        public void OnDrawGizmos()
        {
            Gizmos.DrawSphere(draw , 1f);
        }


        private Vector3 CalculateNeighbours(Transform target)
        {
            if (target == null)
            {
                return Vector3.zero;
            }
            
            Vector3 alignmentMove = Vector3.zero;

            var velocity = target.GetComponent<Rigidbody>().velocity * offset;


            alignmentMove = target.position + velocity;



            return alignmentMove;
        }
    }
}
