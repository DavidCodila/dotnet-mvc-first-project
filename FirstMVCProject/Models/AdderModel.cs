namespace FirstMVCProject.Models;

public class AdderModel()
{
    private int number = 1;

    public int Number
    {
        get { return number; }
    }

    public AdderModel(int numberToAdd) : this()
    {
        this.number += numberToAdd;
    }

}