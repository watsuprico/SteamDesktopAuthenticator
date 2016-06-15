<h1 align="center">
  <img  src="http://i.imgur.com/60QOYqG.jpg"/>
  <br/>
  Steam Desktop Authenticator (SDA)
</h1>
<p align="center">
  A desktop implementation of Steam's mobile authenticator app.<br/>
  <!--<sup>This fork is managed by Watsuprico and uses <a href="https://github.com/IgnaceMaes/MaterialSkin">a material design look.</a>-->
</p>
<h3 align="center">
  <a href="https://github.com/watsuprico/SteamDesktopAuthenticator/releases/latest">Download here</a>
</h3>
<p align="center">
  <b>REMEMBER: Always make backups of your <code>maFiles</code> directory! If you lose your encryption key or delete <code>maFiles</code> by accident AND you didn't save your revocation code, you are screwed.</b>
  <br/>
  <br/>
  IF you lost your <code>maFiles</code> OR lost your encryption key, go <a href="https://store.steampowered.com/twofactor/manage">here</a> and click "Remove Authenticator" then enter your revocation code that you wrote down when you first added your account to SDA.
</p>

<br/>
<br/>

<h1 align="center">
  Setting up SDA
</h1>
  - Download and install [.NET Framework 4.5.2](http://go.microsoft.com/fwlink/?LinkId=397707) if you are running Windows 7 or below.
  - Visit [the releases page](https://github.com/watsuprico/SteamDesktopAuthenticator/releases) and download the [latest release](https://github.com/watsuprico/SteamDesktopAuthenticator/releases/latest). (Should be named SDA_X_X_X_X.zip)
  - Extract the files inside the zip anywhere on your computer, (the desktop is a good example). Please remember to keep the files save, as these allow you to login to your account.
  - Run 'Steam Desktop Authenticator.exe', allow 'vcredist_x86.exe' to run and install, (needed for the trade confirmations browser), and click next to setup your account. <img src="http://i.imgur.com/lRGJ7f8.png"/>
   - Login to Steam and follow the instructions to set it up. <b><i>Please know that you'll need a way of recieving SMS messages. <a href="https://voice.google.com">Google Voice</a> offers this for free.</b></i>
   - After setting your account up, you'll be asked to enable encryption. While not necessary, it is recommended you both enable encryption and use a different password then the one for Steam. <img src="http://i.imgur.com/OtRTW48.png"/>
   - For your safety, remember to get [Steam Guard backup codes](https://store.steampowered.com/twofactor/manage) and make a backup of SDA!

<br/>
<br/>

<h2 align="center">
  Compiling SDA for yourself
</h2>
- Download & Install the free [Visual Studio Community](https://www.visualstudio.com/post-download-vs?sku=community&clcid=0x409).
- Download & Install [GitHub Desktop](https://desktop.github.com/).
- Open GitHub Desktop & sign in with your GitHub account.
- Clone the repository by clicking: [GitHub Desktop](github-windows://openRepo/https://github.com/Watsuprico/SteamDesktopAuthenticator)
- Open the .sln file with Visual Studio
- Build it (`CTRL + Shift + B`)

**OR**
- [Download SDA's master branch](https://github.com/watsuprico/SteamDesktopAuthenticator/archive/master.zip) and [download Steam Auth](https://github.com/geel9/SteamAuth/archive/master.zip) 
- Extract SDA's master brach anywhere. *(Like `C:\Users\%username%\Desktop\SDA-Master\`)*
 - Extract Steam Auth into `\lib\SteamAuth\` *(Like `C:\Users\%username%\Desktop\SDA-Master\lib\SteamAuth\`)*

<br/>
<br/>

<h2 align="center">
  Troubleshooting SDA
</h2>
If your problem doesn't appear in the [Wiki](https://github.com/watsuprico/SteamDesktopAuthenticator/wiki), or none of the solutions worked, submit an issue on the issue tracker. When posting logs in an issue, please upload it to some site like [Pastebin](http://www.pastebin.com).

<br/>
<br/>



<!--<h1 align="center">
  Themes
</h1>
<p align="center">
  SDA has a <a href="https://github.com/IgnaceMaes/MaterialSkin">material design look</a> to it which also allows for custom theming.
  <br/>
  In the theme editor you can customize the theme using Google's color pallete... <img src="http://i.imgur.com/Z0ZvQ0I.png"/>
  <br/>
  ...or select your own! <img src="http://i.imgur.com/NGYQ0gM.png"/>
</p>-->
