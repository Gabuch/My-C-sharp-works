#include "iostream"
#include "string"
#include <Windows.h>

using namespace std;

void stroka3() {
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	setlocale(0, "");
	string text;
	getline(cin, text);
	int check = 0;
	for (int i = 0; i < text.length(); i++) {
		if (text[i] == 'À' || text[i] == 'à') {
			check++;
		}
	}
	cout << "\n" << check;
}