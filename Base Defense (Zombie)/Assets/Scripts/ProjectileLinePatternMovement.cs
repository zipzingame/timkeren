﻿using UnityEngine;
using System.Collections;

public class ProjectileLinePatternMovement : MonoBehaviour {

    public float speed = 10;

	void Update () {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
	}
}