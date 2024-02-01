#include <stdio.h>
#include <tchar.h>
#include <string.h>
#include <stdlib.h>
#include <MIDIData.h>

#define N 64 // 1行の最大文字数(バイト数)

int main() {
	FILE* fp; // FILE型構造体
	errno_t err; // errno_t型(int型)
	char fname[] = "..\\..\\RomMidi.txt";
	char str[N];

	err = fopen_s(&fp, fname, "r"); // ファイルを開く。失敗するとNULLを返す。
	if (err != 0) {
		printf("%s file not open!\n", fname);
		return err;
	}

	MIDIData* pMIDIData;
	MIDITrack* pMIDITrack;
	/* MIDIデータの生成(フォーマット0,トラック数1,TPQNベース,120) */
	pMIDIData = MIDIData_Create(MIDIDATA_FORMAT0, 6, MIDIDATA_TPQNBASE, 24);
	if (pMIDIData == NULL) {
		printf("MIDIデータの生成に失敗しました。\n");
		return 0;
	}
	/* 最初のトラックへのポインタを取得 */
	pMIDITrack = MIDIData_GetFirstTrack(pMIDIData);
	/* イベントを挿入 */
	//MIDITrack_InsertTrackName(pMIDITrack, 0, _T("ちょうちょ")); /* タイトル */
	//MIDITrack_InsertTempo(pMIDITrack, 0, 60000000 / 120); /* 120BPM */
	
	char* s1;
	int ss = 0;
	int data1[6];
	char* context;

	while (fgets(str, N, fp) != NULL) {
		s1 = strtok_s(str, ",", &context);
		while (s1 != NULL) {
			data1[ss] = atoi(s1);
			s1 = strtok_s(NULL, ",", &context);  /* 2回目以降 */
			ss++;
		}
		ss = 0;
		
		if (data1[0] == 1) MIDITrack_InsertProgramChange(pMIDITrack, data1[1], data1[2], data1[3]);
		if (data1[0] == 2) MIDITrack_InsertTempo(pMIDITrack, data1[1], 60000000 / data1[2]);
		if (data1[0] == 3) MIDITrack_InsertNote(pMIDITrack, data1[1], data1[2], data1[3], data1[4], data1[5]);
		if (data1[0] == 4) MIDITrack_InsertTimeSignature(pMIDITrack, data1[1], data1[2], data1[3], data1[4], data1[5]);
		if (data1[0] == 5) MIDITrack_InsertEndofTrack(pMIDITrack, data1[1]);
		if (data1[0] == 6) MIDITrack_InsertControlChange(pMIDITrack, data1[1], data1[2], data1[3], data1[4]);
	}

	fclose(fp); // ファイルを閉じる

	/* MIDIデータを保存 */
	MIDIData_SaveAsSMF(pMIDIData, _T("RomMidi.mid"));
	/* MIDIデータをメモリ上から削除 */
	MIDIData_Delete(pMIDIData);
	pMIDIData = NULL;
	return 1;
}