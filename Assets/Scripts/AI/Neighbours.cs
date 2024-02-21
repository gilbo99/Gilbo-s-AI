using System.Collections.Generic;
using UnityEngine;


namespace Gilbo
{
    public class Neighbours : MonoBehaviour
    {
        
        public List<Transform> friends;
        private Perception perception;

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


                        AddFriends(perception.view[i]);
                        
                        
                    }
                }
            }
        }

        public void AddFriends(GameObject fri)
        {
            friends.Add(fri.transform);
        }
    }
    
}
