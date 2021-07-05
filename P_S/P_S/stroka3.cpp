#include <iostream>
#include <string>
#include "stroka3.h"

using namespace std;

void stroka3() {
	setlocale(LC_ALL, "Russian");
	cout << "¬ведите слово" << " ";
	string str;
	cin >> str;
	for (int i = 0; i < str.length(); i++) {
		if (i == 0) {
			cout << " ";
		}
		else if (i == str.length() - 1) {
			cout << ".";
		}
		else {
			cout << str[i];
		}
	}
	
}

