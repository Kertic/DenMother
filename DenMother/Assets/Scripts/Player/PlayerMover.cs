using UnityEngine;

namespace Structure
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;



        public void SetMovementSpeed(float inMovementSpeed)
        {
            if (movementSpeed >= 0.0f)
                movementSpeed = inMovementSpeed;
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
                transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }

            if (Input.GetButton("Right"))
            {
                transform.Translate(Vector3.right * movementSpeed);
                transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            }
        }
    }
}