#include "P_S.h"
#include "proverka.h"
void P_S()
{
	string str, str1;
	cout << "Введите длину:" << " ";
	getline(cin, str);
	if (!proverka(str)) {
		cout << "Введите действительное число" << '\n';
		P_S();
	}
	else {
		cout << "Введите ширину:" << " ";
		getline(cin, str1);
	}
	if (!proverka(str1)) {
		cout << "Введите действительное число" << '\n';
		P_S();
	}
	else {
		if (str.find("/") == -1 and str.find(".") == str.rfind(".")) {
			double c = 0.0;
			double d = 0.0;
			stringstream ss(str1);
			ss >> c;
			stringstream dd(str);
			dd >> d;
			double P = 2 * (c + d);
			double S = c * d;
			cout << "Периметр прямоугольника:" << " " << P << endl;
			cout << "Площадь прямоугольника:" << " " << S << endl;
		}
		else
			P_S();
	}
}