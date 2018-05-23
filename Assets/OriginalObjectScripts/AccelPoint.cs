using UnityEngine;
using System.Collections;
using UnityEngine;
 
public class AccelPoint : MonoBehaviour {

	public class MoveAnime {
		private const float _RADIAN = 3.1415f / 180;
		public static float[] GetBrake(uint frame, float distance) {
			float a = 90.0f / frame;
			float[] p = new float[frame];
			for (uint i = 0; i < frame; i++) p[i] = Math.Sin (i * a * MoveAnime._RADIAN) * distance;
			return p;
		}
		public static float[] GetAccel(uint frame, float distance) {
			float a = 90.0f / frame;
			float[] p = new float[frame];
			for (uint i = 0; i < frame; i++) p[i] = (1 - Math.Sin ((i * a + 90) * MoveAnime._RADIAN)) * distance;
			return p;
		}
	}



 
    void OnTriggerEnter (Collider other)
	{
		other.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, 10),
			ForceMode.VelocityChange);
	}
}
