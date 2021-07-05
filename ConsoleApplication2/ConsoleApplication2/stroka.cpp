#include "iostream"
#include "string"

using namespace std;

void stroka() {
	setlocale(0, "");
	string text;
	getline(cin, text);
	cout << text << "«»";
}
