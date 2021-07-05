#include "iostream"
#include "string"

using namespace std;

void stroka1() {
	string text;
	getline(cin, text);
	int check = 0;
	for (int i = 0; i < text.length(); i++) {
		if (text[i] == ' ' && check == 0) {
			check = 1;
			i++;
		}
		if (check == 1) {
			cout << text[i];
		}
	}
}