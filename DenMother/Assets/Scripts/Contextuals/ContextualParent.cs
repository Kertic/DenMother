using System.Security.AccessControl;
using UnityEngine;

namespace Contextuals
{
	public class ContextualParent : MonoBehaviour
	{

		[SerializeField] private RectTransform motherTransform;

		[SerializeField] private RectTransform ContextualTransform;
		// Use this for initialization
		void Start () {
		
		}


		private void FixedUpdate()
		{
		//If the transforms are intersecting	

		}

		public bool AreTwoRectsColliding(RectTransform rectA, RectTransform rectB)
		{
			Vector2 originA = rectA.anchoredPosition - new Vector2(rectA.rect.width * 0.5f, rectA.rect.height * 0.5f);
			Vector2 originB = rectB.anchoredPosition - new Vector2(rectB.rect.width * 0.5f, rectB.rect.height * 0.5f);
			
		}
	}
}
