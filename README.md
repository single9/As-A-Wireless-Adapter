# As A Wireless Adapter

## Description

先前在找如何將筆電當作一個無線網路分享器/基地台的時候，發現最好用的方式是透過netsh下去設定，問題是每次要開都要打指令，這顯得非常的麻煩與難用，所以我才想要寫一個這樣的小工具出來。
    
這個程式利用的原理很簡單，僅僅是將指令轉化成為簡單的圖形化的介面，目的是為了簡化那些繁瑣的筆電轉換成為無線網路交換器的開啟過程。

目前還有改進的空間，例如，這個程式目前不會最小化到 tray bar 裡面，不會自動偵測是否已經啟動過服務，不會記憶SSID與密碼...等等。

This program use Windows command `netsh` to turn your PC or laptop into a WiFi access point.

Some feature can be Add:

- Minimize to tray.
- Service Detecte.
- Remember SSID and password.

## Requirement

- Operate System only for Windows XP / 7
- .Net Framework 3.5 (or later)

## Installation

沒有安裝這件事情，不過可能需要你安裝 Visual Studio 2010 (或更新) 或是 MonoDevelop 來編譯出執行檔。

No installation required. But you maybe need install Visual Studio 2010 (or later) or MonoDevelop to build the program.

## Licensing

Free to use, no license.