using System;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Serialization;

public class ShopDonatController : MonoBehaviour
{
    public TextMeshProUGUI money1Text;
    public TextMeshProUGUI money2Text;
    public TextMeshProUGUI money3Text;
    public GameObject purschaisePanel;

    public string donat = "test";
    public string donat2 = "test2";
    public string donat3 = "test3";
    
public void UpdateMoney1(Product product)
    {
        money1Text.text = product.metadata.localizedPrice + " " + product.metadata.isoCurrencyCode;
    }

    public void UpdateMoney2(Product product)
    {
        money2Text.text = product.metadata.localizedPrice + " " + product.metadata.isoCurrencyCode;
    }

    public void UpdateMoney3(Product product)
    {
        money3Text.text = product.metadata.localizedPrice + " " + product.metadata.isoCurrencyCode;
    }
    
    public void OnPurchaseComplete(Product product)
    {
        Debug.Log("Покупка прошла успешно");
        if (product.definition.id == donat)
        {
            purschaisePanel.SetActive(true);
        }
        else if (product.definition.id == donat2)
        {
            purschaisePanel.SetActive(true);
        }
        else if (product.definition.id == donat3)
        {
            purschaisePanel.SetActive(true);
        }
    }

}
