using UnityEngine;

public class Process : MonoBehaviour
{
    public Manager manager;

    private void Awake()
    {
        manager = FindObjectOfType<Manager>();
    }


    public void ConvertToClear(string type, int conversionValue)
    {
        switch (type)
        {
            case "coal":
                if (manager._coal >= conversionValue)
                {
                    manager._coal -= conversionValue;
                    manager._coalClear += 1;
                }
                break;
            case "silver":
                if (manager._silver >= conversionValue)
                {
                    manager._silver -= conversionValue;
                    manager._silverClear += 1;
                }
                break;
            case "gold":
                if (manager._gold >= conversionValue)
                {
                    manager._gold -= conversionValue;
                    manager._goldClear += 1;
                }
                break;
                // Add more cases as needed
        }
    }

    public void ConvertToClearMAX(string type, int conversionValue)
    {
        switch (type)
        {
            case "coal":
                if (manager._coal > 0)
                {
                    int total_coal = manager._coal / conversionValue;
                    manager._coalClear += total_coal;
                    manager._coal -= total_coal * conversionValue;
                }
                break;
            case "silver":
                if (manager._silver > 0)
                {
                    int total_silver = manager._silver / conversionValue;
                    manager._silverClear += total_silver;
                    manager._silver -= total_silver * conversionValue;
                }
                break;
            case "gold":
                if (manager._gold > 0)
                {
                    int total_gold = manager._gold / conversionValue;
                    manager._goldClear += total_gold;
                    manager._gold -= total_gold * conversionValue;
                }
                break;
                // Add more cases as needed
        }
    }


    //public void CoalToClear_coal()
    //{
    //    if (manager._coal >= 15)
    //    {
    //        manager._coal -= 15;
    //        manager._coalClear += 1;
    //    }
    //}

    //public void CoalToClear_coalMAX()
    //{
    //    if (manager._coal > 0)
    //    {
    //        int total_coal = manager._coal / 15;
    //        manager._coalClear += total_coal;
    //        manager._coal -= total_coal * 15;
    //    }
    //}
}
