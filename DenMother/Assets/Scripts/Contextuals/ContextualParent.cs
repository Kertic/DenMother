using System.Security.AccessControl;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Contextuals
{
    public class ContextualParent : MonoBehaviour
    {
        [SerializeField] private RectTransform motherTransform;

        [SerializeField] private RectTransform contextualTransform;

        [SerializeField] private GameObject prompt;

        [SerializeField] private UnityEvent onPressEvent;
        // Use this for initialization
        void Start()
        {
        }


        private void FixedUpdate()
        {
            if (AreTwoRectsColliding(motherTransform, contextualTransform))
            {
                prompt.SetActive(true); 
                if (Input.GetButtonDown("Interact"))
                {
                   onPressEvent.Invoke(); 
                }
            }
            else
            {
                prompt.SetActive(false);
            }
        }

        public bool AreTwoRectsColliding(RectTransform rectA, RectTransform rectB)
        {
            Vector2 originA = new Vector2(rectA.rect.xMin, rectA.rect.yMin) +
                              new Vector2(rectA.position.x, rectA.position.y);
            Vector2 originB = new Vector2(rectB.rect.xMin, rectA.rect.yMin) +
                              new Vector2(rectB.position.x, rectB.position.y);
            Vector2 extentA = new Vector2(rectA.rect.xMax, rectA.rect.yMax) +
                              new Vector2(rectA.position.x, rectA.position.y);
            Vector2 extentB = new Vector2(rectB.rect.xMax, rectB.rect.yMax) +
                              new Vector2(rectB.position.x, rectB.position.y);
            if (originA.y > extentB.y|| originB.y > extentA.y)
                return false;
            if (originA.x > extentB.x || originB.x > extentA.x)
                return false;
            return true;
        }
    }
}