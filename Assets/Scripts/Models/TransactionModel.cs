using System;

[Serializable]
public class TransactionModel
{
    public string title;
    public float amount;
    public string category;
    public string transactionType;
    public string description;

    public TransactionModel(string title, float amount, string category, string transactionType, string description)
    {
        this.title = title;
        this.amount = amount;
        this.category = category;
        this.transactionType = transactionType;
        this.description = description;
    }

}
