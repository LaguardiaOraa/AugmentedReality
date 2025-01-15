using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public event Action OnMainMenu;
    public event Action OnItemMenu;
    public event Action OnARPosition;
    public static GameManager Manager;

    private void Awake()
    {
        if (Manager != null && Manager != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Manager = this;
        }
    }

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("MainMenu activated");
    }
    public void ItemMenu()
    {
        OnItemMenu?.Invoke();
        Debug.Log("ItemMenu activated");
    }
    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("ARPosition activated");
    }
    public void Quit()
    {
        Application.Quit();
    }

    private void Start()
    {
        MainMenu();
    }
}
