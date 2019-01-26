using System.Security.AccessControl;
using UnityEngine;

namespace Contextuals
{
    public class ContextualParent : MonoBehaviour
    {
        [SerializeField] private RectTransform motherTransform;

        [SerializeField] private RectTransform ContextualTransform;

        // Use this for initialization
        void Start()
        {
        }


        private void FixedUpdate()
        {
            //If the transforms are intersecting	
            if(Input.GetButton("Interact"))
                if(AreTwoRectsColliding(motherTransform,ContextualTransform))
                    Debug.Log("They are colliding");
                else
                    Debug.Log("They are not colliding");
        }

        public bool AreTwoRectsColliding(RectTransform rectA, RectTransform rectB)
        {
            Vector2 originA = new Vector2(rectA.rect.xMin, rectA.rect.yMin) + rectA.anchoredPosition;
            Vector2 originB = new Vector2(rectB.rect.xMin, rectA.rect.yMin) + rectB.anchoredPosition; 
            Vector2 extentA = new Vector2(rectA.rect.xMax, rectA.rect.yMax) + rectA.anchoredPosition;
            Vector2 extentB = new Vector2(rectB.rect.xMax, rectB.rect.yMax) + rectB.anchoredPosition;
            if (originA.y > extentB.y|| originB.y > extentA.y)
                return false;
            if (originA.x > extentB.x || originB.x > extentA.x)
                return false;
            return true;
        }
    }
}