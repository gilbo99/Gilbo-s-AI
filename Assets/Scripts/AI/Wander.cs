using UnityEngine;

namespace Gilbo
{
    public class Wander : MonoBehaviour
    {
        public float perlin;
        [SerializeField]
        private Rigidbody rb;
        public float speed;
        [SerializeField]
        private float offset;


        public float minOffset;
        public float maxOffset;

        public void Start()
        {
            offset = Random.Range(minOffset,maxOffset);
        }

       
        private void FixedUpdate()
        {
            perlin = Mathf.PerlinNoise1D(Time.time + offset);
            perlin -= .5f;
            rb.AddRelativeTorque(0,perlin * speed ,0);
            
        }
    }
}

