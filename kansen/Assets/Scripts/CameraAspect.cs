using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAspect : MonoBehaviour {

	GameObject viewObject;
	Transform tr;
	Vector3 pos;

	// Use this for initialization
	void Start () {
		AspectResize();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// アスペクト比サイズ変更
	void AspectResize()
	{
		// スクリーンサイズからの作成時の画面サイズで比率を出す
		// 例:)縦画面の1125(iPhone10)/1080(FullHD)は1.041667の比率でサイズが変更される
		float w = Screen.width / 1080.0f;
		// 例:)縦画面の2436(iPhone10)/1080(FullHD)は1.26875の比率でサイズが変更される
		float h = Screen.height / 1920.0f;
		// キャンバスの描画部分を取得する
		viewObject = GameObject.Find("Title/Canvas/View");
		// 描画部分のTransformを取得
		tr = viewObject.GetComponent<Transform>();
		// 一度縦横で比率を合わせる
		pos.x = w;
		pos.y = h;
		pos.z = 1.0f;   // 奥行きは固定
		tr.localScale = pos; // 比率調整したサイズを格納

		pos = tr.localPosition; // サイズ変更前の中心座標を取得
								// 横の比率で合わせた場合縦の位置を移動させる
		//pos.y -= (1920 * w - Screen.height) / 2;
		tr.localPosition = pos; // 
	}
}
