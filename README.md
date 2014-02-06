# As A Wireless Adapter

## Description

先前在找如何將筆電當作一個無線網路分享器/基地台的時候，發現最好用的方式是透過netsh下去設定，問題是每次要開都要打指令，這顯得非常的麻煩與難用，所以我才想要寫一個這樣的小工具出來。
    
這個程式利用的原理很簡單，僅僅是將指令轉化成為簡單的圖形化的介面，目的是為了簡化那些繁瑣的筆電轉換成為無線網路交換器的開啟過程。

This program use Windows command `netsh` to turn your PC or laptop into a WiFi access point.

## Requirement

- Operate System only for Windows XP / 7
- .Net Framework 3.5 (or later)

## Installation

沒有安裝這件事情，不過可能需要你安裝 Visual Studio 2010 (或更新) 或是 MonoDevelop 來編譯出執行檔。

No installation required. But you maybe need install Visual Studio 2010 (or later) or MonoDevelop to build the program.

## Change Log

**Hotfix 02062014**

- 修正縮小至公劇烈後會顯示在 ALT+TAB 的切換窗的問題

**Version 1.02.05.2014**

- 點下啟動後現在會自動跳到 WiFi 狀態標籤

**Version 1.01.27.2014**

- 加入防止重複啟動機制
- 加入 TabController 使畫面更乾淨

**Version 1.12.04.2013**

- 啟動與停止按鈕現在狀態更清楚
- 關閉程式時會將你的熱點一起關閉
- 每次從縮小狀態開啟程式時會更新連線狀態
- 新增兩個選項讓你選擇是否縮小與儲存設定
- 新增一個重新整理按鈕，用以查看連線狀態

## Licensing

Free to use, no license.