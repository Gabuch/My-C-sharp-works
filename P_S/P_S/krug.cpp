#include "krug.h"
void krug()
{
	string str;
	cout << "������� �������:" << " ";
	getline(cin, str);
	double c = 0.0;
	stringstream dd(str);
	dd >> c;
	if (!proverka(str)) {
		cout << "������� �������������� �����" << '\n';
		krug();
	}
	if (str.find("/") == -1 and str.find(".") == str.rfind(".")) {
		double pi = 3.14;
		double r = sqrt(c / pi);
		double d = r * 2;
		double l = 2 * pi * r;
		cout << "������� ����������=" << d << endl;
		cout << "����� ����������=" << l << endl;
	}
	else
		krug();
}
