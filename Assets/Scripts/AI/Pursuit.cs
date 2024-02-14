using System;
using System.Collections.Generic;
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
        public void Start()
        {
            eyes = GetComponent<GilboEyes>();
            rb = GetComponent<Rigidbody>();
            neighbours = GetComponent<Neighbours>();
        }

        public void FixedUpdate()
        {
            Vector3 target = CalculateNeighbours(pursuitTarget);
            rb.AddForce(target * strength, ForceMode.Force);
            
        }
        
        
        private Vector3 CalculateNeighbours(Transform target)
        {
            if (target == null)
            {
                return Vector3.zero;
            }
            
            Vector3 alignmentMove = Vector3.zero;

            var test = target.GetComponent<Rigidbody>().velocity;


            alignmentMove = (target.position + test) * offset;



            return alignmentMove;
        }
    }
}
