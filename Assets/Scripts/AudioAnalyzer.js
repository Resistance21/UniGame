#pragma strict

function Start () {

}

function Update () {
	var spectrum : float[] = AudioListener.GetSpectrumData(1024, 0, FFTWindow.Hamming);
	
	var c1 : float = spectrum[3] + spectrum[2] + spectrum[4];
	
	Debug.Log("low; " + c1);
}