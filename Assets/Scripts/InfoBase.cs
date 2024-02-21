using UnityEngine;

namespace Gilbo
{
    public class InfoBase : MonoBehaviour
    {
        
        public Rigidbody rb;
        public Vector3 size;
        public float sqrmag;
        
        void OnEnable()
        {
            if (GetComponent<Rigidbody>() != null)
            {
                rb = GetComponent<Rigidbody>();
            }
            
            size = GetComponent<Collider>().bounds.size;

            sqrmag = size.sqrMagnitude;

        }

    }
}
