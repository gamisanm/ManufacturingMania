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
    public bool isProcessing;
    public float processTime = 20f;
    public float elapsedTime = 0f;

    public List<ResourceData> resourcesToTakeAway;
    public List<ResourceData> resourcesToGive;

    private void Start()
    {
        startButton.onClick.AddListener(StartProcessing);
        stopButton.onClick.AddListener(StopProcessing);
        gameObject.SetActive(true);
    }

    public void StopProcessing()
    {
        if (isProcessing)
        {
            CancelInvoke("UpdateProcessing");
            elapsedTime = 0f;
            isProcessing = false;
        }
    }

    public void StartProcessing()
    {
        if (!isProcessing && gameObject.activeSelf)
        {
            isProcessing = true;
            InvokeRepeating("UpdateProcessing", 0f, 0.1f);
        }
    }


    private void UpdateProcessing()
    {
        if (!gameObject.activeSelf && isProcessing)
        {
            elapsedTime += 0.1f;
            progressSlider.value = elapsedTime / processTime;

            if (elapsedTime >= processTime)
            {
                elapsedTime = 0f;
                isProcessing = false;

                bool canProcess = true;
                foreach (ResourceData resource in resourcesToTakeAway)
                {
                    if (manager.GetResourceAmount(resource.resourceName) < resource.amount)
                    {
                        canProcess = false;
                        break;
                    }
                }

                if (canProcess)
                {
                    foreach (ResourceData resource in resourcesToTakeAway)
                    {
                        manager.ModifyResourceAmount(resource.resourceName, -resource.amount);
                    }

                    foreach (ResourceData resource in resourcesToGive)
                    {
                        manager.ModifyResourceAmount(resource.resourceName, resource.amount);
                    }
                }
            }
        }
    }
}
