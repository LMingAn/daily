#include <iostream>
using namespace std;

#define nchoosek NULL
#define fprintf printf

int main()
{
	int man = 5, woman = 7, total = 0, group = 4;
	total = man + woman;

	int total_group = nchoosek(total, group);//MATLAB��ʵ�� -- ��12���г�ȡ4�˵����������

	//ȫ��Ϊͬһ�Ա�������
	int all_man = nchoosek(man, 4);
	int all_woman = nchoosek(woman, 4);

	float all_total = (all_man + all_woman) / total_group;//�������������еķֲ�����

	//��ͬ�Ա�������
	int man1_woman3 = nchoosek(man, 1) * nchoosek(woman, 3);//1��3Ů
	int man2_woman2 = nchoosek(man, 2) * nchoosek(woman, 2);//2��2Ů -- ������
	float all_totalwoman = (man1_woman3 + man2_woman2) / total_group;
	int man3_woman1 = nchoosek(man, 3) * nchoosek(woman, 1);//3��1Ů
	float all_totalman = (man3_woman1 + man2_woman2) / total_group;

	fprintf("ȫ����ͬһ�Ա��Ա��ɵĸ���Ϊ��%.4f\n", all_total);
	fprintf("�ɲ�ͬ�Ա��Ա��ɣ���Ů�Բ��������Եĸ���Ϊ��%.4f\n", all_totalwoman);
	fprintf("�ɲ�ͬ�Ա��Ա��ɣ������Բ�����Ů�Եĸ���Ϊ��%.4f\n", all_totalman);
}