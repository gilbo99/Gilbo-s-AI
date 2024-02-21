using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gilbo
{
    public class Perception : MonoBehaviour
    {
        private GilboEyes eyes;
        public float perception;
        public float eyeDistance;
        public float eyeSize;


        public List<GameObject> view;

        public void OnEnable()
        {
            eyes = GetComponent<GilboEyes>();
            
        }

        public void ClearList()
        {
            view.Clear();
        }

        public void CheckObject(GameObject obj, float distance)
        {

                if (CheckDistance(obj, distance) || CheckSize(obj))
                {
                    AddToView(obj);
                    
                }
            
        }


        private bool CheckDistance(GameObject obj, float distance)
        {

            if (distance < eyeDistance)
            {
                return true;
            }
            return false;
        }
        
        private bool CheckSize(GameObject obj)
        {
            
            
            if (obj.GetComponent<GilboBot>() == null)
            {
                return false;
            }
            
            
            if (obj.GetComponent<GilboBot>().size.sqrMagnitude < eyeSize)
            {
                Debug.Log(obj.GetComponent<GilboBot>().size.sqrMagnitude);
                return true;
            }
            return false;
        }


        


        private void AddToView(GameObject seen)
        {
            if (!view.Contains(seen))
            { 
                view.Add(seen);
            }
          

        }
    }
}

