namespace CustomApp.Models.Pages
{
    class CalculatorModel : AbstractModel
    {
        public static readonly CalculatorModel Instance = new();

        private CalculatorModel() { }

        private static double _lastNumber;
        private static string _lastOperation;
        private static double _lastResult;

        public double LastNumber
        {
            set => SetProperty(ref _lastNumber, value);
            get => _lastNumber;
        }

        public string LastOperation
        {
            set => SetProperty(ref _lastOperation, value);
            get => _lastOperation;
        }

        public double LastResult
        {
            set => SetProperty(ref _lastResult, value);
            get => _lastResult;
        }

        public void Calculate()
        {
            switch (_lastOperation)
            {
                //Add
                case "+":
                    {
                        _lastResult += _lastNumber;
                        _lastNumber = 0;
                        _lastOperation = "";
                        break;
                    }
                //Minus
                case "-":
                    {
                        _lastResult -= _lastNumber;
                        _lastNumber = 0;
                        _lastOperation = "";
                        break;

                    }
                //Multipy
                case "x":
                    {
                        _lastResult *= _lastNumber;
                        _lastNumber = 0;
                        _lastOperation = "";
                        break;
                    }
                //Divide
                case "/":
                    {
                        _lastResult /= _lastNumber;
                        _lastNumber = 0;
                        _lastOperation = "";
                        break;
                    }
                default:
                    {
                        _lastResult = _lastNumber;
                        break;
                    }

            }
        }
    }
}
