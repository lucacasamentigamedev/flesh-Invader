using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBullet
{

    void Shoot(Transform spawnTransform, float speed);
    void Shoot(Transform spawnTransform, float speed, IPossessable owner);

}
