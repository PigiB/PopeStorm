using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    [SerializeField] private float _attackDelay;

    private float _lastAttackTime;

    void Awake()
    {
        EntityLocator.Instance.RegisterPlayer(this);
    }

    public void Attack(AttackDirection direction, ElementType type)
    {
        // Check attack cooldown
        if (Time.time - _lastAttackTime < _attackDelay)
        {
            Log.Trace("[Player] Can't attack on cooldown");
            return;
        }

        _lastAttackTime = Time.time;

        // TODO: Actual attack goes here
        Log.Trace(string.Format("[Player] Attack started\nType: {0}, Direction: {1}", type, direction));
    }

    // Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}


}
