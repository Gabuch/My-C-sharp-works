#include "iostream"
#include "string"

using namespace std;

void stroka2() {
	string text;
	getline(cin, text);
	for (int i = 0; i < text.length(); i++) {
		if (text[i] == ' ') {
			cout << "_";
		}
		else {
			cout << text[i];
		}
	}
}
