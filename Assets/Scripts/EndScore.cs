﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndScore : MonoBehaviour {
    public Text text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.text.text = "score: " + Score.scoreTotal;
	}
}
