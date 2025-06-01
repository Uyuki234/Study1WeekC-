# C# コンパイル＆実行用 Makefile（Mono使用）

CSC = csc
MONO = mono

# 引数でSRCが渡されなければ Sample102.cs を使う
SRC ?= Sample102.cs
EXE = $(basename $(SRC)).exe

# デフォルトターゲット
all: run

# コンパイル
build:
	$(CSC) $(SRC) -out:$(EXE)

# 実行（ビルド後）
run: build
	$(MONO) $(EXE)

# クリーンアップ
clean:
	rm -f *.exe *.pdb
	