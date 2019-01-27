using Spine;
using Spine.Unity;
using UnityEngine;

namespace Structure
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;

        public RectTransform Background;

        public void SetMovementSpeed(float inMovementSpeed)
        {
            if (movementSpeed >= 0.0f)
                movementSpeed = inMovementSpeed;
        }

        private void FixedUpdate()
        {
            // GetComponent<Animator>().SetBool("isRunning", true);
            if (Input.GetButton("Up"))
            {
                transform.Translate(Vector3.up * movementSpeed);
                if (movementSpeed > 0)
                    GetComponent<SkeletonAnimation>().AnimationName = "Walk";
            }
            else if (Input.GetButton("Down"))
            {
                transform.Translate(Vector3.down * movementSpeed);
                if (movementSpeed > 0)
                    GetComponent<SkeletonAnimation>().AnimationName = "Walk";
            }

            else if (Input.GetButton("Left"))
            {
                transform.Translate(Vector3.left * movementSpeed);
                if (movementSpeed > 0)
                {
                    transform.localScale = new Vector3(-10.0f, 10.0f, 10.0f);
                    GetComponent<SkeletonAnimation>().AnimationName = "Walk";
                }
            }

            else if (Input.GetButton("Right"))
            {
                transform.Translate(Vector3.right * movementSpeed);
                if (movementSpeed > 0)
                {
                    transform.localScale = new Vector3(10.0f, 10.0f, 10.0f);
                    GetComponent<SkeletonAnimation>().AnimationName = "Walk";
                }
            }
            else
            {
                //    GetComponent<Animator>().SetBool("isRunning", false);
                GetComponent<SkeletonAnimation>().AnimationName = "Idle";
            }


            if (transform.position.x <= 0)
                transform.Translate(new Vector3(0 - transform.position.x, 0, 0));
            if (transform.position.x >= 543)
                transform.Translate(new Vector3(543 - transform.position.x, 0, 0));
            if (transform.position.y <= 0)
                transform.Translate(new Vector3(0, 0 - transform.position.y, 0));
            if (transform.position.y >= 543)
                transform.Translate(new Vector3(0, 543 - transform.position.y, 0));
        }
    }
}