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
            if (movementSpeed > 0.0f)
            {
                GetComponent<Animator>().SetBool("isRunning", true);
                if (Input.GetButton("Up"))
                {
                    transform.Translate(Vector3.up * movementSpeed);
                }
                else if (Input.GetButton("Down"))
                {
                    transform.Translate(Vector3.down * movementSpeed);
                }

                else if (Input.GetButton("Left"))
                {
                    transform.Translate(Vector3.left * movementSpeed);
                    transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                }

                else if (Input.GetButton("Right"))
                {
                    transform.Translate(Vector3.right * movementSpeed);
                    transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
                }
                else
                {
                    GetComponent<Animator>().SetBool("isRunning", false);
                }
            }
        }
    }
}