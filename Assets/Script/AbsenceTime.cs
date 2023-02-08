using System;
using UnityEngine;
using UnityEngine.UI;

public class AbsenceTime : MonoBehaviour
{
    public Text absenceTimeText;
    public int resourcesPerMinute;
    private float lastExitTime;
    public Manager managerScript;
    private int absenceMinutes;

    private void Start()
    {
        lastExitTime = Time.time;
    }

    void Update()
    {
        absenceMinutes = (int)((Time.time - PlayerPrefs.GetFloat("lastExitTime")) / 30f);
        absenceTimeText.text = "Absence time: " + absenceMinutes + " seconds";
        managerScript._stone = absenceMinutes * resourcesPerMinute;
    }


    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("lastExitTime", Time.time);
        PlayerPrefs.Save();
    }


}
