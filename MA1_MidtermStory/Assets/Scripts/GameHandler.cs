using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour {

	public static int playerStat;

	public static bool GameisPaused = false;
	public GameObject pauseMenuUI;
	public AudioMixer mixer;
	public static float volumeLevel = 1.0f;
	private Slider sliderVolumeCtrl;

	public static bool NiceToPigeon = false;


	//the endings
	public static bool gotEnd_lose1a = false;
	public static bool gotEnd_lose2a = false;
	public static bool gotEnd_lose2b = false;
	public static bool gotEnd_lose3a = false;
	public static bool gotEnd_lose3b = false;
	public static bool gotEnd_lose3c = false;
	public static bool gotEnd_lose3d = false;
	public static bool gotEnd_lose4a = false;
	public static bool gotEnd_lose4b = false;
	public static bool gotEnd_lose4c = false;
	public static bool gotEnd_win4a = false;
	public static bool gotEnd_win4b = false;
	public static bool gotEnd_win4c = false;


	void Awake (){
		SetLevel (volumeLevel);
		GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
		if (sliderTemp != null){
			sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
			sliderVolumeCtrl.value = volumeLevel;
		}
		
		//endings tracking
		string sceneName = SceneManager.GetActiveScene().name;
		if (sceneName == "End_Lose1a") {gotEnd_lose1a = true;}
		else if (sceneName == "End_Lose2a") {gotEnd_lose2a = true;}
		else if (sceneName == "End_Lose2b") {gotEnd_lose2b = true;}
		else if (sceneName == "End_Lose3a") {gotEnd_lose3a = true;}
		else if (sceneName == "End_Lose3b") {gotEnd_lose3b = true;}
		else if (sceneName == "End_Lose3c") {gotEnd_lose3c = true;}
		else if (sceneName == "End_Lose3d") {gotEnd_lose3d = true;}
		else if (sceneName == "End_Lose4a") {gotEnd_lose4a = true;}
		else if (sceneName == "End_Lose4b") {gotEnd_lose4b = true;}
		else if (sceneName == "End_Lose4c") {gotEnd_lose4c = true;}
		else if (sceneName == "End_Win4a") {gotEnd_win4a = true;}
		else if (sceneName == "End_Win4b") {gotEnd_win4b = true;}
		else if (sceneName == "End_Win4c") {gotEnd_win4c = true;}
	}

	void Start (){
		pauseMenuUI.SetActive(false);
		GameisPaused = false;
	}

	void Update (){
		if (Input.GetKeyDown(KeyCode.Escape)){
			if (GameisPaused){
				Resume();
			}
			else{
				Pause();
			}
		}
	}

	void Pause(){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameisPaused = true;
	}

	public void Resume(){
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameisPaused = false;
	}

	public void SetLevel (float sliderValue){
		mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
		volumeLevel = sliderValue;
	}

	public void UpdatePlayerStat(int amount){
		playerStat += amount;
		Debug.Log("Current Player Stat = " + playerStat);
	}

	public int CheckPlayerStat(){
		return playerStat;
	}

	public void StartGame(){
		SceneManager.LoadScene("Scene1");
	}

	public void OpenCredits(){
		SceneManager.LoadScene("Credits");
	}

	public void RestartGame(){
		Time.timeScale = 1f;
		SceneManager.LoadScene("MainMenu");
	}

	public void QuitGame(){
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
