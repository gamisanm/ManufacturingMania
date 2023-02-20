using UnityEngine;
using UnityEngine.UI;

public class MoveSprite : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    private Vector3 currentTarget;
    public float speed = 5f;
    public Text textToDisplay;
    public GameObject mineStone;

    private bool hasStarted = false;

    public void StartMove()
    {
        if (!hasStarted)
        {
            hasStarted = true;
            transform.position = Vector2.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, currentTarget) < 0.1f)
            {
                if (currentTarget == endPoint.position)
                {
                    textToDisplay.text = "-1";
                    Invoke("ResetText", 0.15f);
                    currentTarget = startPoint.position;
                }
                else
                {
                    textToDisplay.text = "+1";
                    Invoke("ResetText", 0.15f);
                    currentTarget = endPoint.position;
                }
            }
        }
    }


    private void ResetText()
    {
        textToDisplay.text = "";
    }

}
