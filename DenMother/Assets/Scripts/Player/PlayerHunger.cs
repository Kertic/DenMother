using UnityEngine;
using Structure;
namespace Player
{
	public class PlayerHunger : MonoBehaviour {
        public float hungerRate;
        float hunger = FindObjectOfType<GameManager>().FoodLevel;

        // Use this for initialization
        void Start () {
		
		}
	
		// Update is called once per frame
		void Update () {
            hunger -= hunger * hungerRate;
        }
	}
}
