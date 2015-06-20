using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    private Player _player;

    void Awake()
    {
        EntityLocator.Instance.RegisterInputManager(this);
    }

	void Start ()
    {
        _player = EntityLocator.Instance.Player;
	}
	
	public bool Right
    {
        get
        {
            return Input.GetKey(KeyCode.RightArrow);
        }
    }

    public bool Left
    {
        get
        {
            return Input.GetKey(KeyCode.LeftArrow);
        }
    }

    public bool Fire
    {
        get
        {
            return Input.GetKeyDown(KeyCode.Q);
        }
    }

    public bool Water
    {
        get
        {
            return Input.GetKeyDown(KeyCode.W);
        }
    }

    public bool Air
    {
        get
        {
            return Input.GetKeyDown(KeyCode.E);
        }
    }

    private AttackDirection Direction
    {
        get
        {
            if ((Right && Left))
            {
                return AttackDirection.None;
            }

            if (Right)
            {
                return AttackDirection.Right;
            }

            if (Left)
            {
                return AttackDirection.Left;
            }

            return AttackDirection.None;
        }
    }

    void Update()
    {
        if (Fire)
        {
            _player.Attack(Direction, ElementType.Fire);
        }

        if (Water)
        {
            _player.Attack(Direction, ElementType.Water);
        }

        if (Air)
        {
            _player.Attack(Direction, ElementType.Air);
        }
    }
}
