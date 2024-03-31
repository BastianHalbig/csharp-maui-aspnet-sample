using CustomApp.Models.Pages;

namespace CustomApp.Pages;

public partial class Calculator : ContentPage
{


	public Calculator()
	{
		InitializeComponent();
    }

    private void OnEqualClicked(object? sender, EventArgs e)
    {
        Display.Text = "";
        CalculatorModel.Instance.Calculate();
        Result.Text = CalculatorModel.Instance.LastResult.ToString();
    }

    //Numbers
    private void OnNumberClicked(object? sender, EventArgs e)
    {
        var button = sender as Button;
        Display.Text += button.Text;
        CalculatorModel.Instance.LastNumber = double.Parse(Display.Text);
    }

    private void OnCommaClicked(object? sender, EventArgs e)
    {
        Display.Text += ",";
    }

    //Operations
    private void OnOperationClicked(object? sender, EventArgs e)
    {
        var button = sender as Button;
        CalculatorModel.Instance.LastOperation = button.Text;
        CalculatorModel.Instance.Calculate();

        Display.Text = "";
        Result.Text = CalculatorModel.Instance.LastResult.ToString();
    }


    //TODO: Implement this shit
    private void OnInverseClicked(object? sender, EventArgs e)
    {
        
    }
    private void OnPercentageClicked(object? sender, EventArgs e)
    {
       
    }

    private void OnCEClicked(object? sender, EventArgs e)
    {
        Display.Text = "";
        CalculatorModel.Instance.LastResult = 0;
        CalculatorModel.Instance.LastOperation = "";
    }

    private void OnCClicked(object? sender, EventArgs e)
    {
        Display.Text = "";
        Result.Text = "";
        CalculatorModel.Instance.LastResult = 0;
        CalculatorModel.Instance.LastNumber = 0;
        CalculatorModel.Instance.LastOperation = "";
    }

    private void OnDeletedClicked(object? sender, EventArgs e)
    {
        Display.Text = "";
        Result.Text = "";
        CalculatorModel.Instance.LastResult = 0;
        CalculatorModel.Instance.LastNumber = 0;
        CalculatorModel.Instance.LastOperation = "";
    }

    private void OnOneThroughClicked(object? sender, EventArgs e)
    {
       
    }

    private void OnSquareClicked(object? sender, EventArgs e)
    {
       
    }

    private void OnRootClicked(object? sender, EventArgs e)
    {
       
    }

}