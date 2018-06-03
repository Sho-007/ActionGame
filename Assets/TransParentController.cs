using UnityEngine;
using System.Collections;

public class TransParentController : MonoBehaviour {

	//　透明フロアのタイプ
	public enum FloorType {
		alwaysTra,					//　通れない壁
		sometimesTraAndCollider,	//　透明時には接触も出来ない
		sometimesTra,				//　透明時に接触は出来る
	};

	//　透明フロアのタイプ
	[SerializeField]
	private FloorType floorType;
	//　透明になる間隔時間
	[SerializeField]
	private float transparentTime = 2f;
	//　床の状態が変化してからの時間
	private float nowTime = 0f;
	//　見た目表示コンポーネント
	private MeshRenderer mesh;
	//　床のコライダ
	private Collider col;

	void Start () {
		mesh = GetComponent<MeshRenderer>();
		col = GetComponent<Collider>();
		//　透明フロアのタイプが常に透明であれば表示コンポーネントを無効化
		if(floorType == FloorType.alwaysTra) {
			mesh.enabled = false;
		}	
	}

	void Update () {

		//　時間計測
		nowTime += Time.deltaTime;

		//　フロアタイプが透明関連
		if(floorType == FloorType.sometimesTraAndCollider || floorType == FloorType.sometimesTra) {
			//　床が透明になる間隔時間を超えたら
			if(nowTime >= transparentTime) {
				//　表示コンポーネントを反転
				mesh.enabled = !mesh.enabled;
				//　透明時に接触も出来ないタイプの場合はコライダも反転
				if(floorType == FloorType.sometimesTraAndCollider) {
					col.enabled = !col.enabled;
				}
				nowTime = 0f;
			}
		}
	}
}