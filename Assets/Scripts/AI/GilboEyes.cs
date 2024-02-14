using System;
using System.Collections.Generic;
using Unity.VisualScripting;
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



        public float distance;

        public List<GameObject> obstacles;

        

        public void FixedUpdate()
        {
            obstacles.Clear();
            
            distance = range;
            for (int i = -rays / 2; i < rays / 2; i++)
            {
                float spreadAngle = -maxAngle / (rays - 1);
                Vector3 dir = Quaternion.Euler(0, i * spreadAngle, 0) * transform.forward;
                if (Physics.Raycast(transform.position, dir, out hit, range, mask))
                {
                    if (distance >= hit.distance)
                    {
                        distance = hit.distance;
                        closestAngle = dir; 
                        Debug.DrawRay(transform.position, dir * range, Color.green);
                    }
                    
                    Seeing(hit.transform.gameObject);
                }





                
            }
            
        }

        private void Seeing(GameObject obj)
        {
            
            obstacles.Add(obj);
            
        }

       
    }
}
