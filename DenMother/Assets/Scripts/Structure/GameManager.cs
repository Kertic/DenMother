using System;
using System.Security.AccessControl;
using UnityEngine;

namespace Structure
{
    public class GameManager : MonoBehaviour
    {
        //These represent how many segments you can get with the food storage area and the nest
        public int MaxNestHealth = 3;

        public int MaxStorageHealth = 3;

        //These are the actual healths of those two items. Use the mutator(s) to modify them.
        public int nestHealth;
        public int storageHealth;
        public float EggWarmth;
        public float FoodLevel;
        public float foodValue;

        public float EggDecayRate;
        public GameObject Mother;

        public AudioSource _AudioSource;
        // Use this for initialization
        void Start()
        {
        }

        private void FixedUpdate()
        {
            CooldownTheEgg();
        }


        public void EatAStoredFood()
        {
            if (FoodLevel == 0.0f)
            {
                GameLoss();
            }

            if (storageHealth == 0)
            {
                // print a message tells player that storage health is empty
            }

            //Remove a food from storage Health and increase FoodLevel by some amount
            if (storageHealth > 0)
            {
                storageHealth -= 1;
                FoodLevel += foodValue;
            }
        }
        public void CooldownTheEgg()
        {
            EggWarmth -= EggDecayRate;
            if (EggWarmth <= 0.0f)
            {
                EggWarmth = 0.0f;
                GameLoss();
            }
        }
        public void GameLoss()
        {
            //TODO: Lose Game
        }
        public void SetNestHealth(int newNestHealth)
        {
            if (newNestHealth < 0)
            {
                Debug.Log("Attempted to set nest health to negative number: " + newNestHealth + " Instead set it to 0");
            }

            if (newNestHealth > MaxNestHealth)
            {
                Debug.Log("Attempted to set nest health to value:" + newNestHealth + " greater than maximum of " +
                          MaxNestHealth + ". Instead set it to Max");
            }
        }
        public void SetFoodStorage(int newFoodStorage)
        {
            if (newFoodStorage < 0)
            {
                Debug.Log(
                    "Attempted to set food storage to negative number: " + newFoodStorage + " Instead set it to 0");
            }

            if (newFoodStorage > MaxNestHealth)
            {
                Debug.Log("Attempted to set food storage to value:" + newFoodStorage + " greater than maximum of " +
                          MaxStorageHealth + ". Instead set it to Max");
            }
        }
    }
}