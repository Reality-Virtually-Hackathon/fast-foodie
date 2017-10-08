using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToPopup : MonoBehaviour {

    public GameObject PopupPrefab;
    private float space;
    // Use this for initialization
    public void PopUp() {
        space = 120.0f;
        GameObject PopupMessage = Instantiate(PopupPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        PopupMessage.transform.SetParent(transform.parent);
        PopupMessage.transform.localPosition = transform.localPosition+transform.right*space;
    }
}
