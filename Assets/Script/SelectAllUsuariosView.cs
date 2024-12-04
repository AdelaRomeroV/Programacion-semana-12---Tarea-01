using UnityEngine;
public class SelectAllUsuariosView : MonoBehaviour
{
    private SelectAllUsuariosController sAUC;
    [SerializeField] private GameObject dataDumpPrefab;
    [SerializeField] private GameObject container;
    private void Awake()
    {
        sAUC = GetComponent<SelectAllUsuariosController>();
    }
    public void Execute()
    {
        sAUC.Execute(OnResult);
    }
    private void OnResult(UsuarioDataModel uDM)
    {
        foreach (Transform t in container.GetComponentInChildren<Transform>())
        {
            if (t != container)
            {
                Destroy(t.gameObject);
            }
        }
        foreach (UsuarioModel uM in uDM.data)
        {
            GameObject obj = Instantiate(dataDumpPrefab, container.transform);
            obj.GetComponent<DataDump>().SetText($"Username: {uM.username}\nÚltimo Puntaje: {uM.lastscore}");
        }
    }
}
