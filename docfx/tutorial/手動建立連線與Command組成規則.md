# Command組成規則

* * * *

## 規則

Command = @ + 通道Index + 指令 + 資料 + ID + Checksum + 分隔符號

- 通道Index:從00~02，當設定為FF時表示對所有通道下指令
- 指令 + 資料
  - F : 設定亮度 (0~255)
  - S : 設定Strobe Mode (F1~F10)
  - L : 設定On/Off(0~1)
- ID
  - 只有在設定亮度、Strobe Mode的時候要設定為00
- Checksum
  - 將前面的所有值進行加總，並取總和最後兩位。
- 分隔符號<CR\><LF\>
  - 是換行符號的意思，若使用字串輸入，請使用"\r\n"

舉以下例子:

- 將Channel2的亮度值設定為75
Command : @01F07500E4CRLF (ASCII)

- 將Channel1的Strobe Mode設定為F4
Command : @00S0400B8CRLF (ASCII)