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
    public Button startButton;
    public Button stopButton;
    public Slider progressSlider;
    private bool isProcessing;
    private float processTime = 20f;

    public List<ResourceData> resourcesToTakeAway;
    public List<ResourceData> resourcesToGive;

    private void Start()
    {
        startButton.onClick.AddListener(StartProcessing);
        stopButton.onClick.AddListener(StopProcessing);
    }

    public void StopProcessing()
    {
        if (isProcessing)
        {
            isProcessing = false;
            CancelInvoke();
        }
    }

    public void StartProcessing()
    {
        if (!isProcessing)
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
                return;
            }

            isProcessing = true;
            foreach (ResourceData resource in resourcesToTakeAway)
            {
                manager.ModifyResourceAmount(resource.resourceName, -resource.amount);
            }
            InvokeRepeating("UpdateProcessing", 0f, 1f);
        }
    }

    private void UpdateProcessing()
    {
        if (isProcessing)
        {
            progressSlider.value = progressSlider.value + 1f / processTime;
            if (progressSlider.value >= 1f)
            {
                GiveAnotherResource();
                progressSlider.value = 0f;
            }
        }
    }

    private void GiveAnotherResource()
    {
        foreach (ResourceData resource in resourcesToGive)
        {
            manager.ModifyResourceAmount(resource.resourceName, resource.amount);
        }
    }
}