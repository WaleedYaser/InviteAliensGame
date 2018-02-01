using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {

    public GameObject target;

    [SerializeField]
    Vector3 _offset; 


    void Start () {
        if (!target)
            target = GameObject.FindGameObjectWithTag("Player"); 
	}
	
	void Update () {
        transform.position = new Vector3 (target.transform.position.x,0,0) + _offset;
	}
}
