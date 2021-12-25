
using System;
using UnityEngine;
 
public class timer : MonoBehaviour {
    
	private TextMesh _textMesh;
	public bool isRunning = true;
	private bool _wasRunningLastUpdate;
	private float _elapsedSeconds;
	private float _timeLastUpdate;
	
 
	void Start() {
		_textMesh = GetComponent<TextMesh>();
		InvokeRepeating("updateTextMesh", 0, 0.2f);
	}
 
	public void StartTimer() {
		isRunning = true;
	}
 
	public void ResetTimer() {
		_elapsedSeconds = 0;
	}
 
	public void StopTimer() {
		isRunning = false;
	}
	
	private void updateTextMesh() {
		if (!isRunning) {
			_wasRunningLastUpdate = false;
			return;
		}

		if (_wasRunningLastUpdate) {
			var deltaTime = Time.time - _timeLastUpdate;
			_elapsedSeconds += deltaTime;
		}

		var timeSpan = TimeSpan.FromSeconds(_elapsedSeconds);
		_textMesh.text = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

		_timeLastUpdate = Time.time;
		_wasRunningLastUpdate = true;
	}
}