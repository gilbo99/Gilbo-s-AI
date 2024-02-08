using UnityEngine;

namespace Gilbo
{
    [SelectionBase]
    public class GilboEyes : MonoBehaviour
    {
        public int rays = 2;
        public float maxAngle = 90f;
        public Vector3 closestAngle;
        public LayerMask mask;
        public float range;
        private RaycastHit hit;
       
        public float distanceToObj = 10f;

        public void FixedUpdate()
        {
            /*
            if (Physics.Raycast(transform.localPosition,transform.forward,out hit ,range, mask, QueryTriggerInteraction.Ignore))
            {
                distanceToObj = hit.distance;
                isSeeing = true;
            }
            else
            {
                isSeeing = false;
            }
            
            float currentAngle = -maxAngle / 2;

            for (int i = 0; i < rays; i++)
            {
                Vector3 dir = Quaternion.Euler(0, currentAngle - 90f, 0) * transform.forward;
                
                Debug.DrawRay(transform.position , dir * range, Color.green);
                Physics.Raycast(transform.position, dir, range , mask);
                float spreadAngle = -maxAngle / (rays - 1);
                currentAngle += spreadAngle;

            }
            */
            distanceToObj = 10f;
            for (int i = -rays/2; i < rays/2; i++)
            {
                float spreadAngle = -maxAngle / (rays - 1);
                Vector3 dir = Quaternion.Euler(0, i * spreadAngle, 0) * transform.forward;
                if (Physics.Raycast(transform.position, dir,out hit, range , mask))
                {
                    
                    
                    if (hit.distance > distanceToObj)
                    {
                        distanceToObj = hit.distance;
                        closestAngle = dir;
                    }
                    else
                    {
                        distanceToObj = hit.distance;
                    }
                }
                
                Debug.DrawRay(transform.position, dir * range, Color.green);
            }
            
        }
    }
}
