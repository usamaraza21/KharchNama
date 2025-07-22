using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransactionView : MonoBehaviour
{
    [Header("UI References")]
    public InputField titleInput;
    public InputField amountInput;
    public Dropdown categoryDropdown;
    public Dropdown transactionTypeDropdown;
    public InputField descriptionInput;

    public Button submitButton;

    public void ClearForm()
    {
        titleInput.text = "";
        amountInput.text = "";
        categoryDropdown.value = 0;
        transactionTypeDropdown.value = 0;
        descriptionInput.text = "";
    }
}
