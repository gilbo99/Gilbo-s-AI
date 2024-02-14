using System.Collections.Generic;
using UnityEngine;

namespace Gilbo
{
    public class Alignment : MonoBehaviour
    {
        private Neighbours neighbours;
        private Rigidbody rb;
        public float strength = 1;
        public Vector3 target;

        public void Start()
        {
            rb = GetComponent<Rigidbody>();
            neighbours = GetComponent<Neighbours>();
        }

        public void FixedUpdate()
        {

            target = CalculateNeighbours(neighbours.friends);
            Vector3 cross = Vector3.Cross(transform.forward, target);
            rb.AddRelativeTorque(cross * strength);

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
                alignmentMove += var.transform.forward;
            }

            alignmentMove /= friends.Count;
            return alignmentMove;
        }
    }
}
