// readme
// Makefileを使う際は同じディレクトリで使う！

// ビルド＆実行 ここにファイル名を代入.cs
// make run SRC=Sample.cs

// すべての .exe, .pdb を削除
// make clean

// git add .
// git commit -m "更新内容を記載"
// git push origin main

// プロジェクトSampleを作成
// dotnet new console -o "Sample601"

// 複数動かす時
// .exeファイルを作成（左に動かすやつ全部書く。右には.exeファイルを作る）
// csc Program.cs Person.cs -out:Sample601.exe
// .exeファイルを実行する
// mono Sample601.exe