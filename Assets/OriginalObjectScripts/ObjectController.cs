using UnityEngine;
using UnityEngine.AI;
using System.Collections;
	
	[RequireComponent(typeof(NavMeshAgent))]
	public class ObjectController : MonoBehaviour{
		[SerializeField]
		private Transform[] m_targets = null;
		[SerializeField]
		private float m_destinationThreshould = 0.0f;

		protected NavMeshAgent m_navAgent = null;

		private int m_targetIndex = 0;

		private Vector3 CurrentTargetPosition{
			get
			{
				if(m_targets == null || m_targets.Length <= m_targetIndex )
				{
					return Vector3.zero;
				}

				return m_targets [m_targetIndex].position;
			}
		}

		protected virtual void Start()
		{
			m_navAgent = GetComponent<NavMeshAgent>();
			m_navAgent.destination = CurrentTargetPosition;


			StartCoroutine(UpdateOffMeshLink() );
		}

		private void Update(){
			if(m_navAgent.remainingDistance <= m_destinationThreshould)
			{
				m_targetIndex = (m_targetIndex +1)%m_targets.Length;

				m_navAgent.destination = CurrentTargetPosition;
			}
		}

		private IEnumerator UpdateOffMeshLink(){
			//オフメッシュリンクの挙動が自動モードならこの処理は行わない
			if(m_navAgent.autoTraverseOffMeshLink)
			{
				yield break;
			}

			while(!m_navAgent.isOnOffMeshLink)
			{
				yield return null;
			}

			//NavMeshの挙動を止めます
			


			//オフメッシュリンクと高さに差があるために微調整をする
			OffMeshLinkData offMeshLinkData = m_navAgent.currentOffMeshLinkData;
			Vector3 targetPos = offMeshLinkData.endPos;
			targetPos.y       += transform.position.y - offMeshLinkData.startPos.y;


			yield return OffMeshLinkProcess( targetPos );

			//オフメッシュリンクの計算を完了する
			m_navAgent.CompleteOffMeshLink();

			//NavMeshの挙動を再開する
			m_navAgent.isStopped = false;
		}


	protected virtual IEnumerator OffMeshLinkProcess( Vector3 i_targetPos)
	{
		yield return null;
	}



	}