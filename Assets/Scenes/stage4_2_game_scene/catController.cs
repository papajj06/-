using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catController : MonoBehaviour
{
    GameObject player;

    // Use this for initialization
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        // 프레임마다 등속으로 낙하시킨다.
        transform.Translate(0, -0.045f, 0);

        // 화면 밖으로 나오면 오브젝트를 소멸시킨다.
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
            gameManage.total++;
        }

        // 충돌 판정
        Vector2 p1 = transform.position; // 화살의 중심 좌표
        Vector2 p2 = this.player.transform.position; // 플레이어의 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.3f; // 화살 반경
        float r2 = 0.8f; // 플레이어 반경

        if (d < r1 + r2)
        {
            gameManage.score -= 10;
            gameManage.total++;
            //GameObject director = GameObject.Find("GameDirector");
            //director.GetComponent<GameDirector>().DecreaseHp();
            // 충달하면 화살을 소멸시킨다.
            Destroy(gameObject);
        }
    }
}
