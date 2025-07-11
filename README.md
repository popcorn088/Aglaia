# Aglaia v2.1.0
AlgaiaはIESファイルのためのエディタです．
![image](https://github.com/popcorn088/Aglaia/assets/51944267/439809c9-fe0f-4c93-a250-eaef822ef922)

## インストール
Aglaia.Package_2.1.0.0_x86_x64.msixbundleを実行します．

## 使い方
### IESファイルの読み込み
メニュー「File」->「Open」からIESファイルを指定する．
どちらもIESファイルがフォーマットを満たしていればIESファイルの内容が表示されます．

### IESファイルの保存
メニュー「File」->「Save」をクリックして名前を指定すると表示されている内容をIESファイルとして保存することができます．

### 扱える規格について
以下の規格を指定することができます．
* LM63-1986
* LM63-1991
* LM63-1995
* LM63-2002
* LM63-2019

ただし，動作が確認されているのはLM63-2002と2019のTypeCだけです．

### Keywordsセクションについて
KeywordsセクションではKeywordとその設定値を閲覧/編集することができます．
keyword列では[]で囲まれている名前を，value列にはkeywordの内容が表示されます．
右クリックのコンテキストメニューから追加や削除が可能です．

### Tiltセクションについて
Tiltセクションを閲覧/編集することができます．
Tiltセクションの設定は次の3つを選択することができます．
* NONE
* INCLUDE
* FILE
FILEを選択したのTILTファイルの位置は現在のファイルの相対パスであることに注意してください．

表の上で右クリックをするとコンテキストメニューが表示され，追加と削除が選択できます．
追加をクリックすると1行追加されて角度と係数を編集することができるようになります．

### Dataセクションについて
Dataセクションは測光データ以外のデータを左下に，測光データは右上に表示されます．
水平角度は行ヘッダーに，垂直角度は列ヘッダーに表示されます．

表の上で右クリックをするとコンテキストメニューが開き，水平角度と垂直学度の追加/削除ができます．
追加をクリックすると角度入力のテキストボックスが表示されるので新しい角度を入力してください．
入力された角度は自動的にソートされます．
行や列を移動や交換することはできません．

### 直射照度分布
「Illuminance」ボタンを押すと直射照度分布を表示します．
この画像のシミュレーションは横(Width)1m，縦(Length)1mの床面に対し，中央に高さ(Height)1mの位置に光源を設定したものです．
光源の向きはi軸を床面に対して垂直に設置し，j軸を右向き，k軸を下向きにしたものです．
Scaleは1/10に設定しています．

### 配光特性
配光特性はDataセクションの配光分布を元に表示されます．
赤の曲線はA-A(水平角度0度)，紫の曲線はB-B(45度)，青の曲線はC-C(90度)に対応しています．
各々のスライダーによって角度を変更することができます．
Nickは参照角度の刻み値を変更することができます．
