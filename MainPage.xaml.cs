using Microsoft.Maui.Controls;

namespace ToDo
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Check for valid card
        static bool IsValid(string cardNumber)
        {
            int sum = 0;
            bool isSecondDigit = false;
            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                if (cardNumber[i] < '0' || cardNumber[i] > '9')
                {
                    // Invalid character, return false
                    return false;
                }
                int digit = cardNumber[i] - '0';
                if (isSecondDigit)
                {
                    digit *= 2;
                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }
                sum += digit;
                isSecondDigit = !isSecondDigit;
            }
            return sum % 10 == 0;
        }

        // Get the card type
        static string GetCardType(string cardNumber)
        {
            if (cardNumber.Length == 15 && (cardNumber.StartsWith("34") || cardNumber.StartsWith("37")))
            {
                return "Amex";
            }
            else if (cardNumber.Length == 16 && (cardNumber.StartsWith("51") || cardNumber.StartsWith("52") || cardNumber.StartsWith("53") || cardNumber.StartsWith("54") || cardNumber.StartsWith("55")))
            {
                return "MasterCard";
            }
            else if ((cardNumber.Length == 13 || cardNumber.Length == 16) && cardNumber.StartsWith("4"))
            {
                return "Visa";
            }
            else
            {
                return "Unknown";
            }
        }

        // Our button onclick
        private async void OnSubmitButtonClicked(object sender, EventArgs e)
        { 

            string cardNumber = entryCardNumber.Text;

            if (cardNumber.Length == 0)
            {
                await DisplayAlert("Alert", "Please Enter a card number", "OK");
                return;
            }

            if (IsValid(cardNumber))
            {
                // await DisplayAlert("Card Type", $"{GetCardType(cardNumber)}", "OK");

                // Create a new label with the value of the entry
                Label newLabel = new Label
                {
                    Text = cardNumber + " - " + GetCardType(cardNumber),
                    FontSize = 18,
                };

                Frame frame = new Frame
                {
                    Content = newLabel,
                    BorderColor = Colors.LightGray,
                    CornerRadius = 10,
                };


                // Add the new label to the stack layout
                stackLayout.Children.Add(frame);
            }

            else
                await DisplayAlert("Error", "Invalid Card", "OK");

            entryCardNumber.Text = "";
        }
    }
}
