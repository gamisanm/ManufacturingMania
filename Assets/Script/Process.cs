using UnityEngine;

public class Process : MonoBehaviour
{
    public Manager manager;

    private void Awake()
    {
        manager = FindObjectOfType<Manager>();
    }

    public void WoodToPlanks()
    {
        if (manager.Wood >= 15)
        {
            manager.Wood -= 15;
            manager.Planks += 1;
        }
    }

    public void WoodToPlanksMAX()
    {
        if (manager.Wood > 0)
        {
            int totalPlanks = manager.Wood / 15;
            manager.Planks += totalPlanks;
            manager.Wood -= totalPlanks * 15;
        }
    }
}
