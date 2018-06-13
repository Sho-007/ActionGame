using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent( typeof( NavMeshAgent ) )]
public class  Warp :MonoBehaviour

{
	[SerializeField]
	private float   m_scaleTime = 0.0f;
	[SerializeField]
	private float   m_waitTime  = 0.0f;

	protected override IEnumerator OffMeshLinkProcess( Vector3 i_targetPos )
	{
		Vector3 defaultScale    = transform.localScale;

		yield return new WaitForSeconds( m_waitTime );

		yield return ScaleProcess( Vector3.zero, m_scaleTime );

		yield return new WaitForSeconds( m_waitTime );

		transform.position  = i_targetPos;

		yield return ScaleProcess( defaultScale, m_scaleTime );

		yield return new WaitForSeconds( m_waitTime );
	}

	private IEnumerator ScaleProcess( Vector3 i_toScale, float i_time )
	{
		Vector3 fromScale = transform.localScale;

		float startTime = Time.time;
		float endTime   = startTime + i_time;

		while( Time.time < endTime )
		{
			float elapsedTime = Time.time - startTime;
			float elapsedRate = elapsedTime / i_time;

			Vector3 scale           = Vector3.Lerp( fromScale, i_toScale, elapsedRate );
			transform.localScale    = scale;

			yield return null;
		}

		transform.localScale    = i_toScale;
	}

} 