using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrangeTime : MonoBehaviour {

	public int pan;
	//public int knifes
	public string[] busyActions;
	public string[] relaxActions;
	// Use this for initialization
	void Start () {
		busyActions = new string[]{ "stri", "fly", " cut" };
		relaxActions = new string[]{"boil","bake"};

        //recipes = GameObject.FindGameObjectsWithTag("Recipe");
    }
	
	// Update is called once per frame
	void Update () {
        // ThisStep = recipe.GetComponent<Text>().text;
        //if()
    }
}
