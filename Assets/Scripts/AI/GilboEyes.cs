using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Gilbo
{
    [SelectionBase]
    public class GilboEyes : GilboBot
    {
        [Range(0, 50)]
        public int rays = 2;
        [Range(0, 380f)]
        public float maxAngle = 90f;
        public Vector3 closestAngle;
        public LayerMask mask;
        public float range;
        private RaycastHit hit;
        [Range(0, 5f)]
        public float eyeRate;

        private int hits;

        private Perception perception;



        public float distance;
        

        public void Start()
        {
            perception = GetComponent<Perception>();
            distance = range;
            eyeRate += Random.Range(0f, 3f);
            StartCoroutine(nameof(See));
        }


        IEnumerator See()
        {
            while (true)
            {
                perception.ClearList();

                distance = range;
                for (int i = -rays / 2; i < rays / 2; i++)
                {
                    float spreadAngle = -maxAngle / (rays - 1);
                    Vector3 dir = Quaternion.Euler(0, i * spreadAngle, 0) * transform.forward;
                    if (Physics.Raycast(transform.position, dir, out hit, range, mask, QueryTriggerInteraction.Collide))
                    {
                        if (distance >= hit.distance)
                        {
                            distance = hit.distance;
                            closestAngle = dir;
                        }

                        perception.CheckObject(hit.collider.gameObject, hit.distance);
                    }
                }
                
                yield return new WaitForSeconds(eyeRate);
            }
        }

        

    }
}
