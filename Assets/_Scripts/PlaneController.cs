﻿using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {
    //PUBLIC INSTANCE VARIABLES
    public float speed = 5;

    //PRIVATE INSTANCE VARIABLES
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
	
	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;

        this._playerInput = Input.GetAxis("Horizontal");

        // if player movement is positive move right
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(this.speed, 0);
        }

        // if player movement is negative move left
        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(this.speed, 0);
        }

        if (this._currentPosition.x < -285)
            this._currentPosition.x = -285;

        if (this._currentPosition.x > 285)
            this._currentPosition.x = 285;


        
        this._transform.position = this._currentPosition;
	}
    //PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void _checkBounds()
    {

    }
}
