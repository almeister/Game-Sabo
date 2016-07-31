﻿using UnityEngine;using System.Collections;[RequireComponent(typeof(CharacterController))][RequireComponent(typeof(MeshFilter))]public class Duckling : MonoBehaviour {    protected float speed = 6f;    protected float rotationalSpeed = 3f;    protected CharacterController controller;    protected Vector3 movement = Vector3.zero;	// Use this for initialization	public virtual void Start () {        controller = GetComponent<CharacterController>();        if (!controller)        {            Debug.LogError("Duckling.Start() " + name + " has no CharacterController.");            enabled = false;        }	}		// Update is called once per frame	public virtual void Update () {        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationalSpeed, 0);        Vector3 forward = transform.TransformDirection(Vector3.forward);        float curSpeed = speed * Input.GetAxis("Vertical");        controller.SimpleMove(forward * curSpeed);	}}