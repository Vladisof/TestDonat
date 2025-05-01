using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Serialization;

public class ShopDonatController : MonoBehaviour
{
    public TextMeshProUGUI money1Text;
    public GameObject purschaisePanel;
    
  

    public string donat = "test";



public void UpdateMoney1(Product product)
    {
        money1Text.text = product.metadata.localizedPrice + " " + product.metadata.isoCurrencyCode;
    }

    
    public void OnPurchaseComplete(Product product)
    {
        Debug.Log("Покупка прошла успешно");
        if (product.definition.id == donat)
        {
            purschaisePanel.SetActive(true);
        }
    }

}
