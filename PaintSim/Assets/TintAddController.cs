using UnityEngine;

public class TintAddController : MonoBehaviour
{
    public float pourRateFast;
    public float pourRateSlow;
    public int totalRedTint;
    public int totalGreenTint;
    public int totalBlueTint;
    public bool slowPour;
    private TintChoiceController tintChoiceController;

    private float timer;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (!tintChoiceController.GetIsFastPour())
            {
                timer += Time.deltaTime; // Increment the timer with the elapsed time
                if (timer >= pourRateSlow)
                {
                    if(tintChoiceController.GetIsRed())
                    {
                        totalRedTint++; // Increment totalRedTint by 1
                        timer = 0f; // Reset the timer
                    }
                    
                }
            }
            else
            {
                timer += Time.deltaTime;
                if (timer>= pourRateFast)
                {
                    totalRedTint++; // Increment totalRedTint by 1
                    timer = 0f;
                }
                
            }
        }
    }
}
