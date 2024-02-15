using UnityEngine;

namespace Gilbo
{
    public class InfoBase : MonoBehaviour
    {
        
        public Rigidbody rb;
        public Vector3 size;
        
        void Start()
        {
            if (GetComponent<Rigidbody>() != null)
            {
                rb = GetComponent<Rigidbody>();
            }
            
            size = GetComponent<Collider>().bounds.size;
        }

    }
}
