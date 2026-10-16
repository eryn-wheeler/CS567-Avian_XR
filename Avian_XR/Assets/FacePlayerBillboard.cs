using UnityEngine;

public class FacePlayerBillboard : MonoBehaviour {
    private Camera targetCamera;

    void Start() {
        //Find the headset camera
        if (Camera.main != null)
        {
            targetCamera = Camera.main;
        }
    }

    void LateUpdate() {
        if (targetCamera == null) 
        return;

        //make the label face directly toward the camera
        transform.forward = transform.position - targetCamera.transform.position;
    }
}