using UnityEngine;

public class ToggleCallout : MonoBehaviour {
    [SerializeField] private GameObject targetCallout;

    void Start() {
        //Make sure that the label is hidden at first 
        if (targetCallout != null) {
            targetCallout.SetActive(false);
        }
    }

    public void ToggleVisibility() {
        if (targetCallout != null) {
            targetCallout.SetActive(!targetCallout.activeSelf);
        }
    }
}