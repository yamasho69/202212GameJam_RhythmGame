using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour {
	public AudioClip bgm;
	//private AudioSource audioSource;// オーディオソース
	SoundManager soundManager;
	public FadeController fadeController;
	public int score;

	// Use this for initialization
	void Start () {
		// オーディオソース取得
		GameObject gameObject = GameObject.FindGameObjectWithTag("SoundManager");
		soundManager = gameObject.GetComponent<SoundManager> ();
		//soundManager.PlayBgm(bgm);

		//ゲームデータロード
		/*
		score = ES3.Load<int>("SCORE", defaultValue: 0);
		Level = ES3.Load<int>("LEVEL", defaultValue: 0);
		isClear = ES3.Load<bool>("CLEAR", defaultValue:false);
		*/
	}

	// ゲームデータをセーブ
	void SaveGameData () {
		/*
		ES3.Save<int>("SCORE", score);
		ES3.Save<int>("LEVEL", placeLevel);
		ES3.Save<bool>("CLEAR", isClear);
		*/
	}
}
