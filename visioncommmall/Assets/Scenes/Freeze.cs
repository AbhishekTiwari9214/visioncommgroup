using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Freeze : MonoBehaviour {
	public Button openButton;
	public Button closeButton;

	void Start () {
		Button btn = openButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

		Button btn2 = closeButton.GetComponent<Button>();
		btn2.onClick.AddListener(TaskOnClick2);
	}

	void TaskOnClick(){
		Time.timeScale = 0;
	}

	void TaskOnClick2(){
		Time.timeScale = 1;
	}
}