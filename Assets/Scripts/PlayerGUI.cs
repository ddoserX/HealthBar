using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Player))]
public class PlayerGUI : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private Player _player;
    private Coroutine _job;

    private void Awake() {
        _player = GetComponent<Player>();

        _slider.maxValue = _player.MaxHealth;
    }

    public void HealthUpdate() {
        float currect = _player.Health;

        if (_job != null) {
            StopCoroutine(_job);
        }

        _job = StartCoroutine(SmoothHealthChange());
    }

    private IEnumerator SmoothHealthChange() {
        while(_slider.value != _player.Health) {
            _slider.value = Mathf.MoveTowards(_slider.value, _player.Health, 0.4f);

            yield return null;
        }
    }
}
