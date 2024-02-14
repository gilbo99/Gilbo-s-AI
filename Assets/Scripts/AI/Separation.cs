using System.Collections.Generic;
using UnityEngine;

namespace Gilbo
{
    public class Separation : MonoBehaviour
    {
        private Neighbours neighbours;
        private GilboEyes eyes;
        private Rigidbody rb;
        public float strength;

        public void Start()
        {
            neighbours = GetComponent<Neighbours>();
            eyes = GetComponent<GilboEyes>();
            rb = GetComponent<Rigidbody>();
        }


        public void FixedUpdate()
        {
            Vector3 target = CalculateNeighbours(neighbours.friends);
            rb.AddForce(target * strength, ForceMode.Force);

        }


        private Vector3 CalculateNeighbours(List<Transform> friends)
        {
            if (friends.Count == 0)
            {
                return Vector3.zero;
            }
            
            
            Vector3 alignmentMove = Vector3.zero;
            
            foreach (Transform var in friends)
            {
                
                alignmentMove +=  (transform.position - var.position).normalized;
            }
            
            alignmentMove /= friends.Count;
            return alignmentMove;
        }
    }
}
