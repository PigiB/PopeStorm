using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private ElementType _type;

    [SerializeField] private float _movementSpeed;

    [SerializeField] private float _attackDelay;

    [SerializeField] private float _attackDamage;

    [SerializeField] private Animator _animator;

	// Use this for initialization
	void Start () {
        _animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.O))
        {
            _animator.SetTrigger("Flower");
        }
	}
}
