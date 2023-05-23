using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spells : MonoBehaviour
{
    [SerializeField] private Player _targetPlayer;

    private float _damage = 10f;
    private float _healPower = 10f;

    public void Hit() {
        _targetPlayer.SetHealth(_targetPlayer.Health - _damage);
    }

    public void Heal() {
        _targetPlayer.SetHealth(_targetPlayer.Health + _healPower);
    }
}
