using UnityEngine;

public class TransactionController : MonoBehaviour
{
    public TransactionView view;

    private void Start()
    {
        view.submitButton.onClick.AddListener(OnSubmitTransaction);
    }

    private void OnSubmitTransaction()
    {
        string title = view.titleInput.text;
        float amount = float.Parse(view.amountInput.text);
        string category = view.categoryDropdown.options[view.categoryDropdown.value].text;
        string transactionType = view.transactionTypeDropdown.options[view.transactionTypeDropdown.value].text;
        string description = view.descriptionInput.text;

        TransactionModel newTransaction = new TransactionModel(title, amount, category, transactionType, description);

        // For now, just log it
        Debug.Log("Transaction Added: " + JsonUtility.ToJson(newTransaction));

        // TODO: Save to JSON or SQLite
        view.ClearForm();
    }
}
