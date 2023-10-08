#Secure Storage App with .NET MAUI

##App Screenshot
![PANIC-2](https://github.com/erdalkama/SecureStorageMaui/assets/34250103/c502d764-39e8-4f94-89bc-dfc66c0de625)

This is a simple cross-platform app developed with .NET MAUI that demonstrates how to securely store and manage sensitive data, such as access tokens, in a mobile application. It provides a user-friendly interface for users to input, save, display, and delete their access tokens while ensuring data security.

##Features

Securely store access tokens.
Retrieve and display saved access tokens.
Delete access tokens when needed.
Cross-platform compatibility (Android and iOS).

##Getting Started

To get started with this project, follow these steps:

Clone this repository:

git clone https://github.com/erdalkama/SecureStorageMaui.git

Open the project in Visual Studio or your preferred .NET MAUI development environment.
Build and run the app on your desired platform (Android or iOS emulator or device).
Use the app to securely store and manage access tokens.

##Usage

Saving an Access Token: Enter your access token in the provided field and click the "Save" button.
Displaying an Access Token: Click the "Show" button to display the saved access token.
Deleting an Access Token: Click the "Delete" button to remove the saved access token.

##Configuration

Before publishing your app for Android and iOS, ensure data security:

Android Configuration:
Set android:allowBackup="false" in the androidmanifest.xml file.
Create an auto_backup_rules.xml file in the Android/Resources/xml folder and specify backup rules.
iOS Configuration:
Create an Entitlements.plist file within the iOS folder and define keychain access groups to allow secure data storage.

##Contributing

Contributions are welcome! If you have any ideas for improvements or want to fix a bug, please feel free to open an issue or submit a pull request.

##Authors

Erdal Kama

##Contact

If you have any questions or suggestions, feel free to reach out to ekama@cu.edu.tr.
