#include <iostream>
using namespace std;

#define nchoosek NULL
#define fprintf printf

int main()
{
	int man = 5, woman = 7, total = 0, group = 4;
	total = man + woman;

	int total_group = nchoosek(total, group);//MATLAB中实现 -- 在12人中抽取4人的所有组合数

	//全部为同一性别的组合数
	int all_man = nchoosek(man, 4);
	int all_woman = nchoosek(woman, 4);

	float all_total = (all_man + all_woman) / total_group;//在所有组合情况中的分布概率

	//不同性别的组合数
	int man1_woman3 = nchoosek(man, 1) * nchoosek(woman, 3);//1男3女
	int man2_woman2 = nchoosek(man, 2) * nchoosek(woman, 2);//2男2女 -- 不少于
	float all_totalwoman = (man1_woman3 + man2_woman2) / total_group;
	int man3_woman1 = nchoosek(man, 3) * nchoosek(woman, 1);//3男1女
	float all_totalman = (man3_woman1 + man2_woman2) / total_group;

	fprintf("全部由同一性别成员组成的概率为：%.4f\n", all_total);
	fprintf("由不同性别成员组成，但女性不少于男性的概率为：%.4f\n", all_totalwoman);
	fprintf("由不同性别成员组成，但男性不少于女性的概率为：%.4f\n", all_totalman);
}