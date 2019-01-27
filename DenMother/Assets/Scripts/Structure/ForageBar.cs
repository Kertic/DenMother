using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

namespace Structure
{
	public class ForageBar : MonoBehaviour
	{

		public Image uiFill;

		public GameManager manager;	
		// Use this for initialization
		void Start () {
		
		}
	
		// Update is called once per frame
		void Update ()
		{
			uiFill.fillAmount = manager.timeSpentForaging / manager.forageDuration;
			uiFill.gameObject.SetActive(uiFill.fillAmount >= 0.0f);
		}
	}
}
