# Telegram Exporter from Android devices

- Tries to find Telegram data on Android device and exports it to local machine.
- Made and Tested on Windows 10.
- Application requires ADB to communicate with the Android device.
- This software is under BSD 2-Clause "Simplified" License.

**NOTE**: This will work with the first device that gets detected. If you have multiple
phones attached to you machine only the first one will be backed up.

If you close the program the copying of the files will still continue until finished. This
is one thing that needs to be fixed.

![Screenshot](https://github.com/mitjafelicijan/telegram-exporter/assets/296714/286509ad-1345-4499-8c21-2b0949100a34)

## Installation && Usage

- Go to the [Releases](https://github.com/mitjafelicijan/telegram-exporter/releases) and
  download the latest binary build.
- Then extract the zip and execute telegram-exporter.exe.
- When application is opened you need to setup path to ADB.exe that you need to have already
  installed on your local machine.
- If you do not have it installed go to [SDK Platform Tools](https://developer.android.com/tools/releases/platform-tools)
  and download them and unzip them locally.
- Make sure that you have enabled USB Debugging on target Android device.
- Click on "Detect available Devices" and if one is found you will see id appear bellow the button.
- After all that is done click "Check for Telegram Data" button and this will show you if 
  application found Telegram presence on the device.
- If data was found you will get an option to click "Copy Data to Local Machine"
  button. This button will trigger mass copy of all Telegram related data on your local
  machine. This may take a while. I suggest you check the output folder to see files
  being copied. After the copy phase is done you will recieve an alert telling you
  data was copied.
