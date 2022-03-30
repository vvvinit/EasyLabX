using UnityEngine;

public class GyroControl : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rotation;

    /*
     * Start fn is called before the first frame update
     */
    void Start()
    {
        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);

        gyroEnabled = EnableGyro();
    }

    /*
     * Check whether device supports gyroscope interactions.
     */
    private bool EnableGyro()
    {
        /*
         * Set default orientations if gyroscope is available.
         */
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rotation = new Quaternion(0, 0, 1, 0);

            return true;
        }

        return false;
    }

    /* 
     * Update is called once per frame
     */
    void Update()
    {
        /*
         * Interact with gyroscope if supported.
         */
        if (gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rotation;
        }
    }
}
