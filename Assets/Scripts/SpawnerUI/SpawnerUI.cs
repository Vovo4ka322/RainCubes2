using UnityEngine;
using TMPro;

public abstract class SpawnerUI : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI CountOfCreatedObjectsText;
    [SerializeField] protected TextMeshProUGUI CountOfActiveObjectsText;
    [SerializeField] protected string NameOfObject;

    private void Start()
    {
        Draw(0, 0);
    }

    protected void Draw(int countOfCreatedObjects, int countOfActiveObjects)
    {
        CountOfCreatedObjectsText.text = "Кол-во созданных объектов " + NameOfObject + ": " + countOfCreatedObjects.ToString();
        CountOfActiveObjectsText.text = "Кол-во активных объектов " + NameOfObject + ": " + countOfActiveObjects.ToString();
    }
}