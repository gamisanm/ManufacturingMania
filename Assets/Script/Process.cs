using UnityEngine;

public class Process : MonoBehaviour
{
    public Manager manager;

    private void Awake()
    {
        manager = FindObjectOfType<Manager>();
    }

    public void CoalToClear_coal()
    {
        if (manager._coal >= 15)
        {
            manager._coal -= 15;
            manager._coalClear += 1;
        }
    }

    public void CoalToClear_coalMAX()
    {
        if (manager._coal > 0)
        {
            int total_coal = manager._coal / 15;
            manager._coalClear += total_coal;
            manager._coal -= total_coal * 15;
        }
    }
}
