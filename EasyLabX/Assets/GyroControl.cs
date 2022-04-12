using UnityEngine;

public class GyroControl : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion initialRotation, gyroInitialRotation;

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

            initialRotation = transform.rotation;
            gyroInitialRotation = Input.gyro.attitude;

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
            Quaternion offsetRotation = Quaternion.Inverse(gyroInitialRotation) * Input.gyro.attitude;
            transform.rotation = initialRotation * Quaternion.Inverse(offsetRotation);
        }
    }
}