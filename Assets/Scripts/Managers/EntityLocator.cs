using UnityEngine;
using System.Collections;

public class EntityLocator : Singleton<EntityLocator>
{
    public GameManager GameManager { get; private set; }

    public void RegisterGameManager(GameManager toRegister)
    {
        if (GameManager != null)
        {
            throw new System.Exception(string.Format(Strings.DOUBLE_ENTITY_EXCEPTION_1, "GameManager"));
        }

        GameManager = toRegister;
    }

    public Player Player { get; private set; }

    public void RegisterPlayer(Player toRegister)
    {
        if (Player != null)
        {
            throw new System.Exception(string.Format(Strings.DOUBLE_ENTITY_EXCEPTION_1, "Player"));
        }

        Player = toRegister;
    }
    
    public EnemyManager EnemyManager { get; private set; }

    public void RegisterEnemyManager(EnemyManager toRegister)
    {
        if (EnemyManager != null)
        {
            throw new System.Exception(string.Format(Strings.DOUBLE_ENTITY_EXCEPTION_1, "EnemyManager"));
        }

        EnemyManager = toRegister;
    }

    public InputManager InputManager { get; private set; }

    public void RegisterInputManager(InputManager toRegister)
    {
        if (InputManager != null)
        {
            throw new System.Exception(string.Format(Strings.DOUBLE_ENTITY_EXCEPTION_1, "InputManager"));
        }

        InputManager = toRegister;
    }
}
