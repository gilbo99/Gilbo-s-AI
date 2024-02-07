using UnityEngine;

namespace Gilbo
{
    public class GilboEyes : MonoBehaviour
    {
        public LayerMask mask;
        public float range;
        private RaycastHit hit;

        public float distanceToObj;

        public void Update()
        {
            if (Physics.Raycast(transform.localPosition,transform.forward,out hit ,range, mask, QueryTriggerInteraction.Ignore))
            {
                distanceToObj = hit.distance;
            }
        }
    }
}
