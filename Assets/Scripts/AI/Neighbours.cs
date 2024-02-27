using System;
using System.Collections.Generic;
using UnityEngine;


namespace Gilbo
{
    public class Neighbours : MonoBehaviour
    {
        
        public List<Transform> friends;
        private Perception perception;
        public float distance;

        private GilboEyes eyes;
        public void Start()
        {
            perception = GetComponent<Perception>();

        }

        public void FixedUpdate()
        {
            friends.Clear();
            for (int i = 0; i < perception.view.Count; i++)
            {
                if (perception.view[i] != null )
                {
                    if (perception.view[i].GetComponent<GilboEyes>())
                    {

                        if (distance > Vector3.Distance(perception.view[i].transform.position , transform.position))
                        {
                            AddFriends(perception.view[i]);
                        }
                        
                        
                        
                    }
                }
            }
        }

        public void AddFriends(GameObject fri)
        {
            friends.Add(fri.transform);
        }

        private void OnDrawGizmos()
        {
            
            for (int i = 0; i < friends.Count; i++)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, friends[i].transform.position);
            }
            
        }
    }
    
}
