using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private UnityEvent _healthСhanged;
    
    private float _health;

    public float MaxHealth => _maxHealth;
    public float Health { get { return _health; } private set { _health = value; }}

    private void Start() {
        SetHealth(_maxHealth);
    }

    public void SetHealth(float newHealth) {
        if (newHealth < 0) {
            Health = 0;
        }
        else if (newHealth > _maxHealth) {
            Health = _maxHealth;
        }
        else {
            Health = newHealth;
        }

        _healthСhanged?.Invoke();
    }
} 
