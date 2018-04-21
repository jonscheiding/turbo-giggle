﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    private float angle = 0;
    private float velocity = 30.0f;

	// Use this for initialization
	void Start () {
        Debug.Log("Hey there. I have been updated!");
	}
	
	// Update is called once per frame
	void Update () {
        Touch touch = Input.GetTouch(0);
        if (touch.phase == UnityEngine.TouchPhase.Began)
        {
            velocity *= -1;
        }

        transform.localEulerAngles = new Vector3(angle / 2.0f, angle, 0);
        angle += velocity * Time.deltaTime;
	}
}