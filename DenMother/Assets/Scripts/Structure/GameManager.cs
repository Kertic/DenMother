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

        public GameObject Mother;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void EatAStoredFood()
        {


            if (FoodLevel == 0) 
            {
                // player Die here

            }
            if (storageHealth == 0)
            {
                // print a message tells player that storage health is empty
            }

            //Remove a food from storeageHealth and increase FoodLevel by some amount
            storageHealth -= 1;
            {
            FoodLevel += foodValue;
            }
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
                Debug.Log("Attempted to set food storage to negative number: " + newFoodStorage + " Instead set it to 0");
            }

            if (newFoodStorage > MaxNestHealth)
            {
                Debug.Log("Attempted to set food storage to value:" + newFoodStorage + " greater than maximum of " +
                          MaxStorageHealth + ". Instead set it to Max");
            }
        }
    }
}