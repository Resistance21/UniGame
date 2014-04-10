using UnityEngine;
using System.Collections;

public class audioSpecDazzle : MonoBehaviour {
	
	public GameObject cube01;
	public GameObject cube02;
	public GameObject cube03;
	public GameObject cube04;
	
	public float juice = 20f;
	
	public float[] spec;
	
	public float specMag01;
	public float specMag02;
	public float specMag03;
	public float specMag04;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//spec = AudioListener.GetSpectrumData(64,0,FFTWindow.Hamming); // this works on audio source
		spec = AudioListener.GetOutputData (1024,0);  // this gives much  better values.
		
		specMag01 = spec[2] + spec[4];
		specMag02 = spec[12] + spec[14];
		specMag03 = spec[22] + spec[24];
		specMag04 = spec[32] + spec[34];
		
		
		cube01.gameObject.transform.localScale = new Vector3(1f,specMag01*juice,1f);
		cube02.gameObject.transform.localScale = new Vector3(1f,specMag02*juice,1f);
		cube03.gameObject.transform.localScale = new Vector3(1f,specMag03*juice,1f);
		cube04.gameObject.transform.localScale = new Vector3(1f,specMag04*juice,1f);
	}
}﻿