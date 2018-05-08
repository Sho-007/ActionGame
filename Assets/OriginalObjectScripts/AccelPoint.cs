using UnityEngine;
using System.Collections;
 
public class AccelPoint : MonoBehaviour {
 
    void OnTriggerEnter(Collider other){
        other.gameObject.GetComponent&lt;Rigidbody&gt;().AddForce(new Vector3(0,0,10),ForceMode.VelocityChange);
    }
}