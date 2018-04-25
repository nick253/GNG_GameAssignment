using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneHandler : MonoBehaviour {

	public void OnButtonClick(string Done_Main) 
	{
		Application.LoadLevel (Done_Main);
	}
}
