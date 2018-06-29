
using UnityEngine;
using System.Collections;
using System;
 
[Serializable]
public class SaveData : object {
 
	//　publicデータ
	public int hp;
	//　staticデータ
	static int mp;
	//　privateデータ
	private float power;
	//　フラグデータ
	public bool flag;
	//　シリアライズなデータ
	[SerializeField]
	private Vector3 vector;
	[SerializeField]
	private GameObject obj;
 
	public void SetFlag(bool flag) {
		this.flag = flag;
	}
 
	public void SetVector(Vector3 vector) {
		this.vector = vector;
	}
 
	public void SetObj(GameObject obj) {
		this.obj = obj;
	}
 
	public bool IsFlag() {
		return flag;
	}
 
	public Vector3 GetVector() {
		return vector;
	}
 
	public GameObject GetObj() {
		return obj;
	}
 
	public string GetNormalData() {
		return  " flag: " + flag + " vector: " + vector + " obj: " + obj;
	}
 
	public string GetJsonData() {
		return JsonUtility.ToJson(this);
	}		
 
}