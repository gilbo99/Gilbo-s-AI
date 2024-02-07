using UnityEngine;

namespace Gilbo
{ 
    public class AISpawner : MonoBehaviour
    {
        public GameObject gilboAI;
        public float amount;


        public void Start()
        {
            for (int i = 0; i < amount; i++)
            {
                Instantiate(gilboAI);
            }
        }
    }
}
