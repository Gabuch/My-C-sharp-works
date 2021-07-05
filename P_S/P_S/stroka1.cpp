#include "iostream"
#include "string"
#include "stroka1.h"

using namespace std;

void stroka1() {
	setlocale(LC_ALL, "Russian");
	cout << "¬ведите текст" << " ";
	string text;
	getline(cin, text);
	for (int i = 0; i < text.length(); i++) {
		if (text[i] == ' ') {
			i++;
		}
		cout << text[i];
	}
}
