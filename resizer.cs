using UnityEngine;

public class Resizer : MonoBehaviour
{
    public float TotalResizeSeconds = 1f;      // Duration of one resize cycle
    public float ScaleFactorPerSecond = 1f;    // How much scale changes per second
    private float elapsedResizeSeconds = 0f;

    private int scaleFactorSignMultiplier = 1; // +1 = grow, -1 = shrink

    void Update()
    {
        // Update timer
        elapsedResizeSeconds += Time.deltaTime;

        // Apply scaling each frame
        float scaleChange = ScaleFactorPerSecond * scaleFactorSignMultiplier * Time.deltaTime;

        Vector3 localScale = transform.localScale;
        localScale.x += scaleChange;
        localScale.y += scaleChange;
        transform.localScale = localScale;

        // When time is up, flip direction
        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {
            scaleFactorSignMultiplier *= -1;   // reverse scaling
            elapsedResizeSeconds = 0f;         // reset timer
        }
    }
}
