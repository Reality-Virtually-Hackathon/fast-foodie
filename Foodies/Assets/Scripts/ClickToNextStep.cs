using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToNextStep : MonoBehaviour {

    public GameObject next;
    public GameObject Last;
    public void NextStep() {
        next.SetActive(true);
        gameObject.SetActive(false);
    }

    public void LastStep() {
        Last.SetActive(true);
        gameObject.SetActive(false);
    }
}
