using UnityEngine;
using System.Collections;
 
public class DamageReturnArea : MonoBehaviour {
 
    public float power;
 
    private Transform returnPoint;
 
    void Start() {
        returnPoint = transform.Find("ReturnPoint");
    }
 
    private void OnTriggerEnter(Collider collider) {
        string tag = TagUtility.getParentTagName(collider.gameObject);
 
        if (gameObject.tag == "Player") {
			collider.GetComponent<Player>();forceDownDamage(this);
            StartCoroutine("returnCharacter", collider.gameObject);
        }
    }
 
    private IEnumerator returnCharacter(GameObject character) {
        yield return new WaitForSeconds(1f);
 
        character.transform.position = returnPoint.position;
    }
}
