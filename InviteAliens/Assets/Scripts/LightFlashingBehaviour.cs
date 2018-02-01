using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlashingBehaviour : MonoBehaviour {

	public float speed;
	public float scale;
	private float initIntensity;
	private Light lightComponent;
	void Start () {
		lightComponent = GetComponent<Light>();
		initIntensity = lightComponent.intensity;
	}
	
	void Update () {
		lightComponent.intensity = initIntensity + Mathf.Sin(Time.time * speed * Mathf.Deg2Rad) * scale;
	}
}
