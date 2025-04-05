# Card Validator

🔗 [Gihub link](https://github.com/mravaloarison/wallet)

This is a simple `.NET MAUI` application that checks if a credit card number is valid and identifies its type (Visa, MasterCard, Amex or Unknown), based on a project from [Harvard CS50x](https://cs50.harvard.edu/x/2023/psets/1/credit/).

## Requirements
* `XCODE`
* Visual Studio 
* `.NET MAUI`
* Microsoft.Maui.Controls

## Screenshots
<!-- ![Desktop Format](screenshots/desktop.png)
![IOS Format](screenshots/IOS.png)
![Success](screenshots/Success.png)
![Empty input](screenshots/empty_input.png)
![Invalid Card](screenshots/invalid_card.png) -->
<table>
    <tr>
        <td>
            <a href="https://github.com/mravaloarison/wallet/blob/main/screenshots/desktop.png">
                <img src="screenshots/desktop.png" alt="Screenshot Home desktop" width="300px" />
            </a>
        </td>
        <td>
            <a href="https://github.com/mravaloarison/wallet/blob/main/screenshots/Ipad.png">
                <img src="screenshots/Ipad.png" alt="Screenshot home IOS" width="300px" />
            </a>
        </td>
        <td>
            <a href="https://github.com/mravaloarison/wallet/blob/main/screenshots/Iphone.png">
                <img src="screenshots/Iphone.png" alt="Screenshot home Iphone" width="300px" />
            </a>
        </td>
        <td>
            <a href="https://github.com/mravaloarison/wallet/blob/main/screenshots/Android.png">
                <img src="screenshots/Android.png" alt="Screenshot home Android" width="300px" />
            </a>
        </td>
    </tr>
    <tr>
        <td>
            <a href="https://github.com/mravaloarison/wallet/blob/main/screenshots/empty_input.png">
                <img src="screenshots/empty_input.png" alt="Screenshot Empty input" width="300px" />
            </a>
        </td>
        <td>
            <a href="https://github.com/mravaloarison/wallet/blob/main/screenshots/invalid_card.png">
                <img src="screenshots/invalid_card.png" alt="Screenshot Invalid Card" width="300px" />
            </a>
        </td>
        <td>
            <a href="https://github.com/mravaloarison/wallet/blob/main/screenshots/insert_data.png">
                <img src="screenshots/insert_data.png" alt="Screenshot inserting card" width="300px" />
            </a>
        </td>
        <td>
            <a href="https://github.com/mravaloarison/wallet/blob/main/screenshots/success_input.png">
                <img src="screenshots/success_input.png" alt="Screenshot successful card" width="300px" />
            </a>
        </td>
        <td>
            <a href="https://github.com/mravaloarison/wallet/blob/main/screenshots/success.png">
                <img src="screenshots/success.png" alt="Screenshot all type of card" width="300px" />
            </a>
        </td>
    </tr>
</table>

## Usage
To use this application, simply run it on your local machine or emulator, and input a credit card number into the text box provided. If the card number is valid, the application will add a label showing the card number and its type (Visa, MasterCard, Amex or Unknown) to the stack layout. If the card number is invalid, the application will display an error message.

## How it works
This application checks if the entered credit card number is valid using the Luhn algorithm. It then identifies the type of the credit card based on the first few digits of the card number. If the card number is valid, a new label is created with the card number and its type, and added to the stack layout.

## Issues encountered
As I was working on a macOS desktop, there was compatibility issues with the macOS version, Xcode and .NET MAUI installation errors, there was also few issues related to dependencies or libraries used. They were mostly resolved by updating the software, reinstalling or repairing the installation, also troubleshooting dependencies and libraries.
