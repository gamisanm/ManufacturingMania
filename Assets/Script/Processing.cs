using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ResourceData
{
    public string resourceName;
    public int amount;
}


public class Processing : MonoBehaviour
{
    public Manager manager;
    public Button ovenButton;
    public Button stopButton;
    public Slider progressSlider;
    private bool isProcessing;
    private float processTime = 10f;

    public List<ResourceData> resourcesToTakeAway;
    public List<ResourceData> resourcesToGive;

    public void StartProcessing()
    {
        if (!isProcessing)
        {
            bool canStart = true;
            foreach (ResourceData resource in resourcesToTakeAway)
            {
                if (manager.GetResourceAmount(resource.resourceName) < resource.amount)
                {
                    canStart = false;
                    break;
                }
            }

            if (canStart)
            {
                isProcessing = true;
                StartCoroutine(Process());
            }
        }
    }

    public void StopProcessing()
    {
        isProcessing = false;
    }

    IEnumerator Process()
    {
        while (isProcessing)
        {
            bool canProcess = true;
            foreach (ResourceData resource in resourcesToTakeAway)
            {
                if (manager.GetResourceAmount(resource.resourceName) < resource.amount)
                {
                    canProcess = false;
                    break;
                }
            }

            if (!canProcess)
            {
                isProcessing = false;
                break;
            }

            float elapsedTime = 0f;

            // Take away resources before starting the process
            TakeAwayResource();

            while (elapsedTime < processTime && isProcessing)
            {
                progressSlider.value = elapsedTime / processTime;
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            if (isProcessing)
            {
                // Give resources after the process
                GiveAnotherResource();
            }
        }

        isProcessing = false;
    }

    private void TakeAwayResource()
    {
        // Code to take away resources
        foreach (ResourceData resource in resourcesToTakeAway)
        {
            manager.ModifyResourceAmount(resource.resourceName, -resource.amount);
        }
    }

    private void GiveAnotherResource()
    {
        // Code to give resources
        foreach (ResourceData resource in resourcesToGive)
        {
            manager.ModifyResourceAmount(resource.resourceName, resource.amount);
        }
    }
}
