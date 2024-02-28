using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DOtween : MonoBehaviour
{
    [SerializeField] private List<EnemyController> m_enemies;

    private bool m_activated = false;

    private void Awake()
    {
        foreach (EnemyController enemy in m_enemies)
        {
            enemy.GetComponent<creategun>().ShootOnStart = false;
            enemy.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!m_activated && other.gameObject.tag == "player")
        {
            m_activated = true;
            Debug.Log("you touch--------");

            var seq = DOTween.Sequence();
            foreach (EnemyController enemy in m_enemies)
            {
                enemy.gameObject.SetActive(true);

                var pos = enemy.transform.position;

                RaycastHit info;
                if (Physics.Raycast(pos, Vector3.down, out info))
                {
                    pos.y = info.point.y + 3.5f;
                }

                seq.Append(enemy.transform.DOMove(pos, 3)
                    .OnComplete(
                        () => {
                            enemy.GetComponent<creategun>().StartShooting();
                        }
                     ));
            }
        }
    }
}