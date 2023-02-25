using ScriptableData.RuntimeSet;
using UnityEngine;

public class PlayerTeleporter : MonoBehaviour
{
    [SerializeField] private GameObjectRuntimeSet teleportRuntimeSet;
    private Transform playerTransform;
    private CharacterController playerController;
    [SerializeField] private Transform[] portals;

    private void Awake()
    {
        playerTransform = this.transform;
        playerController = GetComponent<CharacterController>();
    }

    void Start()
    {
        portals = new Transform[teleportRuntimeSet.Items.Count];
        for (int i = 0; i < teleportRuntimeSet.Items.Count; i++)
        {
            portals[i] = teleportRuntimeSet.Items[i].transform;
        }
    }

    void Update()
    {
        CheckTeleportInput();
    }

    private void CheckTeleportInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TeleportPlayer(portals[0].position);
            Debug.Log("!1");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TeleportPlayer(portals[1].position);
            Debug.Log("!2");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TeleportPlayer(portals[2].position);
            Debug.Log("!3");
        }
    }

    private void TeleportPlayer(Vector3 position)
    {
        playerController.enabled = false;
        playerTransform.position = position;
        playerController.enabled = true;
    }
}
