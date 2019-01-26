using UnityEngine;

namespace Structure
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;

        // Use this for initialization
        void Start()
        {
        }


        private void FixedUpdate()
        {
            if (Input.GetButton("Up"))
            {
                transform.Translate(Vector3.up * movementSpeed);
            }

            if (Input.GetButton("Down"))
            {
                transform.Translate(Vector3.down * movementSpeed);
            }

            if (Input.GetButton("Left"))
            {
                transform.Translate(Vector3.left * movementSpeed);
            }

            if (Input.GetButton("Right"))
            {
                transform.Translate(Vector3.right * movementSpeed);
            }
        }
    }
}