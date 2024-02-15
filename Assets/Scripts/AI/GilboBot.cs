using UnityEngine;

namespace Gilbo
{
    public class GilboBot : InfoBase
    {
        public Vector3 velocity;
        void FixedUpdate()
        {
            velocity = rb.velocity;
        }

    }
}
