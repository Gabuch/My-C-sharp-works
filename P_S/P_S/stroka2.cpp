#include "iostream"
#include "string"
#include "stroka2.h"
#include <Windows.h>

using namespace std;

void stroka2() {
	setlocale(LC_ALL, "Russian");
	cout << "¬ведите текст" << " ";
	string text;
	getline(cin, text);
	for (int i = 0; i < text.length(); i++) {
		if (i == 0) {
			cout << text[text.length() - 1];
		}
		else if (i == text.length() - 1) {
			cout << text[0];
		}
		else {
			cout << text[i];
		}
	}
}
