using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour {
	const int StageTipSize = 30;

    int currentTipIndex;
    //ターゲットキャラクターの指定
    public Transform charactor;
    //ステージチッププレハブ配列
    public GameObject[] stageTips;
    //自動生成開始インデックス
    public int startTipIndex;
    //生成先読み個数
    public int preInstantiate;
    //ステージチップ保持個数リスト
    public List<GameObject> generatedStageList = new List<GameObject>();

    //初期化処理
	// Use this for initialization
	void Start () {
		currentTipsIndex = startTipIndex - 1;
        UpdateStage(preInstantiate);

	}
	
	// Update is called once per frame
	void Update () {
		
//キャラクターの一から現在のステージチップのインデックスを計算
        int charaPositionIndex = (int)(charactor.position.z/StageTipSize);

        //キャラクターが次のステージチップに入ったらステージ更新処理を行う
        if(chraPositionIndex + preInstantiate > currentTipIndex)
        {
            UpdateStage(charaPositionIndex + preInstantiate);
        }
    }

//ステージの更新処理
//指定のIndexまでのステージチップを生成して管理下に置く
void UpdateStage(int toTipIndex){
    if(toTipIndex <= currentTipIndex) return;

    //指定のステージチップまでを作成
    for (int i = currentTipIndex + 1; i <= toTipIndex; i++ )
    {
        GameObject stageObject = GenarateStage(i);

        //生成したステージチップを管理リストに追加し
        generateStageList.Add(stageObject);
    }

    //ステージ保持上限内になるまで古いステージの削除
    while (generatedStageList.Count > preInstantiate + 2) Destroy01destStage();
    currentTipIndex = toTipIndex;
}

//ステージ生成の処理
//指定のインデックス位置にStageオブジェクトをランダムに生成
GameObject GenerateStage (int tipIndex){
    int nextStageTip = Random.Range(0,stageTips.Length);

    GameObject stageObject = (GameObject)Instanteate(stageTips[nextStageTip],new Vector3(0, 0, tipIndex * StageTipSize),Quaternion.identity);

    return stageObject;
}

//ステージの削除処理
//一番古いステージを削除
void Destroy01destStage(){
    GameObject oldStage = generatedStageList[0];
    generatedStageList.RemoveAt(0);
    Destroy(oldStage);
}
}
