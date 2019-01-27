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
        public int NestHealth;
        public int StorageHealth;
        public float EggWarmth;
        public float FoodLevel;
        public float FoodValue;

        public float EggDecayRate;
        public float FoodDecayRate;
        public GameObject Mother;
        private bool isEggWarming;
        private bool isMomForaging;

        public float timeSpentForaging;

        public float forageDuration;
        // Use this for initialization
        void Start()
        {
            isEggWarming = false;
            isMomForaging = false;
        }

        private void FixedUpdate()
        {
            if (!isEggWarming)
                CooldownTheEgg();
            else
            {
                WarmEgg();
            }

            if (!isMomForaging)
            {
                RemoveFoodFromMom();
                timeSpentForaging = 0.0f;
            }
            else
            {
                timeSpentForaging += (1.0f / 60.0f);
                if (timeSpentForaging >= forageDuration)
                {
                    timeSpentForaging = 0.0f;
                    SetFoodStorage(StorageHealth + 1);
                   SetMomForaging(false); 
                } 
            }
        }


        public void EatAStoredFood()
        {
            if (FoodLevel <= 0.0f)
            {
                GameLoss();
            }

            if (StorageHealth == 0)
            {
                // print a message tells player that storage health is empty
            }

            //Remove a food from storage Health and increase FoodLevel by some amount
            if (StorageHealth > 0)
            {
                StorageHealth -= 1;
                FoodLevel += FoodValue;
                if (FoodLevel >= 1.0f)
                    FoodLevel = 1.0f;
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

        public void RemoveFoodFromMom()
        {
            FoodLevel -= FoodDecayRate;
            if (FoodLevel <= 0.0f)
            {
                FoodLevel = 0.0f;
                GameLoss();
            }
        }

        public void WarmEgg()
        {
            EggWarmth += EggDecayRate;
            if (EggWarmth >= 1.0f)
            {
                EggWarmth = 1.0f;
                SetEggWarming(false);
                Mother.GetComponent<PlayerMover>().SetMovementSpeed(5);
            }
        }

        public void SetEggWarming(bool isEggWarm)
        {
            isEggWarming = isEggWarm;
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
            StorageHealth = newFoodStorage;
            if (newFoodStorage < 0)
            {
                Debug.Log(
                    "Attempted to set food storage to negative number: " + newFoodStorage + " Instead set it to 0");
                StorageHealth = 0;
            }

            if (newFoodStorage > MaxStorageHealth)
            {
                Debug.Log("Attempted to set food storage to value:" + newFoodStorage + " greater than maximum of " +
                          MaxStorageHealth + ". Instead set it to Max");
                StorageHealth = MaxStorageHealth;
            }
        }

        public void SetMomForaging(bool setIsMomForaging)
        {
            isMomForaging = setIsMomForaging;
            Mother.SetActive(!setIsMomForaging);
        }
    }
}