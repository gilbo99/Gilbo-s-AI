using System.Collections.Generic;
using UnityEngine;


namespace Gilbo
{
    public class Neighbours : MonoBehaviour
    {
        
        public List<Transform> friends;

        private GilboEyes eyes;
        public void Start()
        {
            eyes = GetComponent<GilboEyes>();
        }

        public void FixedUpdate()
        {
            friends.Clear();
            for (int i = 0; i < eyes.obstacles.Count; i++)
            {
                if (eyes.obstacles[i].GetComponent<GilboEyes>())
                {
                    AddFriends(eyes.obstacles[i]);
                }
            }
        }

        public void AddFriends(GameObject fri)
        {
            friends.Add(fri.transform);
        }
    }
    
}
