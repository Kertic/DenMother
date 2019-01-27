using UnityEngine;
using UnityEngine.UI;

namespace Structure
{
    public class FoodStatus : MonoBehaviour
    {
        public GameObject[] FoodLevels;

        public GameManager Manager;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            SetFoodVisibility();
        }

        private void SetFoodVisibility()
        {
            for (int i = 0; i < FoodLevels.Length; i++)
            {
                FoodLevels[i].SetActive(Manager.StorageHealth == i);
            }
        }
    }
}