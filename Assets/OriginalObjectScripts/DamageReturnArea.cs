using UnityEngine;
using System.Collections;
 
public class DamageReturnArea : MonoBehaviour {
 
    public float power;
 
    private Transform returnPoint;
 
    void Start() {
        returnPoint = transform.FindChild("ReturnPoint");
    }
 
    private void OnTriggerEnter(Collider c) {
        string tag = TagUtility.getParentTagName(c.gameObject);
 
        if (tag == "Player") {
            c.GetComponent<Player>().forceDownDamage(this);
            StartCoroutine("returnCharacter", c.gameObject);
        }
    }
 
    private IEnumerator returnCharacter(GameObject character) {
        yield return new WaitForSeconds(1f);
 
        character.transform.position = returnPoint.position;
    }
}
