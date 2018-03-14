using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DateManager : MonoBehaviour {
	private string url = "http://サーバーのURL/Date.php";
	//json化したデータの読み込み準備
	public class time
	{
		public int Year;
		public int Month;
		public int Day;
		public int Hour;
		public int Minute;
		public int Second;
	}
	private Text text;
	//jsonを読み込むコルーチンをスタート
	void Start () {
		text = gameObject.GetComponent<Text> ();
		StartCoroutine (Date ());
	}
	//jsonを読み込むコルーチン
	IEnumerator Date (){
		//WWWクラスでファイルに接続
		WWW www = new WWW (url);

			yield return www;
		//json化したファイルをstring型の変数に直す
		string json = www.text;
		//上のstring型の変数をjsonutillityでjsonとして読み込む
		time ntime = JsonUtility.FromJson<time> (json);
		//日付をtextに表示するための準備
		string DateTime =ntime.Year.ToString()+":"+ntime.Month.ToString()+":"+ntime.Day.ToString()+":"+ntime.Hour.ToString()+":"+ntime.Minute.ToString()+":"+ntime.Second.ToString();
		text.text = DateTime;
		yield return new WaitForSeconds(0.1f);
		StartCoroutine (Date ());
	}
}
