using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atc : MonoBehaviour
{
    [SerializeField] ExamineScript script;

    public Button addtoCart;
    public GameObject mainCamera;
    public GameObject examineCamera;
    public GameObject player;
    public bool isExaming;
    public GameObject ExamineUI;
    public GameObject atcUI;
    public GameObject Hud;
    public GameObject ExamineObject;
    public GameObject aboutText;


    // Start is called before the first frame update
    void Start()
    {
		Button btn = addtoCart.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }
    // Update is called once per frame
    void Update()
    {
           	
    }
void TaskOnClick()
	{
	if(script.inReach)
	{
		mainCamera.SetActive(true);
            examineCamera.SetActive(false);
            Time.timeScale = 1;
		script.RealObject.SetActive(false);
		player.SetActive(true);
		isExaming = false;
            ExamineUI.SetActive(false);
		atcUI.SetActive(false);
            Hud.SetActive(true);
            ExamineObject.SetActive(false);
            aboutText.SetActive(false);
	}
	}
}
