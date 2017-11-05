using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class ApiClient : MonoBehaviour {

    const string baseUrl = "http://localhost:51681/API";

	public Text nome_txt;
	public Text peso_txt;
	public Text altura_txt;
    public Text id_txt;
    public Text description_txt;
    public Text tipoItem_txt;
    // Use this for initialization
    void Start () {
        StartCoroutine(GetItensApiAsync());
	}
	

    IEnumerator GetItensApiAsync()
    {
        UnityWebRequest request = UnityWebRequest.Get(baseUrl + "/Itens");
        yield return request.Send();

        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {
            string response = request.downloadHandler.text;
            Debug.Log(response);

            byte[] bytes = request.downloadHandler.data;

            Item[] itens = JsonHelper.getJsonArray<Item>(response);

            foreach (Item i in itens)
            {
                ImprimirItem(i);
            }
        }
    }

    private void ImprimirItem(Item i)
    {
        Debug.Log("======= Dados Objeto ======");

        Debug.Log("ID: " + i.ItemID);
        id_txt.text = "ID: " + i.ItemID.ToString();

        Debug.Log("Nome: " + i.Nome);
        nome_txt.text = "Nome: " + i.Nome;

        Debug.Log("Descrição: " + i.Descricao);
        description_txt.text = "Descricao: " + i.Descricao;

        Debug.Log("Altura: " + i.Altura);
        altura_txt.text = "Altura: " + i.Altura.ToString();

        Debug.Log("Peso: " + i.Peso);
        peso_txt.text = "Peso: " + i.Peso.ToString();

        Debug.Log("TipoItemID: " + i.TipoItemID);
        tipoItem_txt.text = "Tipo de Item: " + i.TipoItem;
    }
	
}
