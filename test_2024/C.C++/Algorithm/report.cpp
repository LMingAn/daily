#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
using namespace std;


//1
//int main()
//{
//	vector<int> num1, num2, nums;
//	int in = 0;
//	cout << "输入num1数据：";
//	while (cin >> in)
//	{
//		num1.push_back(in);
//		if (cin.get() == '\n')
//			break;
//	}
//	cout << "输入num2数据：";
//	while (cin >> in)
//	{
//		num2.push_back(in);
//		if (cin.get() == '\n')
//			break;
//	}
//	num1.insert(num1.end(), num2.begin(), num2.end());
//	sort(num1.begin(), num1.end());
//	cout << '[';
//	for (in = 0; in < num1.size(); in++)
//	{
//		cout << num1[in];
//		if (in != num1.size() - 1)
//			cout << ", ";
//	}
//	cout << ']';
//	return 0;
//}


//2
//int main()
//{
//	int num = 0, ans = 0;
//	vector<int> nums = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59 };
//	long long n = 0;
//	cin >> num;
//	cout << num << "=";
//	while (num != 1)
//	{
//		for (int a = 0; a < nums.size(); a++)
//		{
//			if (num % nums[a] == 0)
//			{
//				num /= nums[a];
//				cout << nums[a];
//				break;
//			}
//		}
//		if (num != 1)
//			cout << "*";
//	}
//	return 0;
//}


//3
//int main()
//{
//	vector<int> nums;
//	int n = 0, a = 0, b = 0, c = 0;
//	cin >> n;
//	for (a = 0; a < n; a++)
//	{
//		cin >> b;
//		nums.push_back(b);
//	}
//	sort(nums.begin(), nums.end());
//	cout << "[";
//	for (a = 0; a < n; a++)
//	{
//		if (a > 0 && nums[a] == nums[a - 1])
//			continue;
//		for (b = a + 1; b < n; b++)
//		{
//			for (c = b + 1; c < n; c++)
//			{
//				if (nums[a] + nums[b] + nums[c] == 0)
//					cout << "[" << nums[a] << ", " << nums[b] << ", " << nums[c] << "] ";
//			}
//		}
//	}
//	cout << "]";
//}


//4
//int main()
//{
//	int m = 0, n = 0;
//	cout << "m = ";
//	cin >> m;
//	cout << "n = ";
//	cin >> n;
//	int a = m, b = n;
//	while (b)
//	{
//		int c = b;
//		b = a % b;
//		a = c;
//	}
//	cout << "最大公约数：" << a << endl;
//	cout << "最小公倍数：" << (m / a * n) << endl;
//	return 0;
//}


//5
//int taking(int n)
//{
//	if (n == 1)
//		return 10;
//	else
//		return taking(n - 1) + 2;
//}
//
//int main()
//{
//	int n = 5, ans = 0;
//	cout << taking(n);
//	return 0;
//}


//6
//void makeSched(int n, vector<vector<pair<int, int>>>& sched)
//{
//	int players = 1 << n;
//	for (int day = 0; day < (n - 1); day++)//遍历比赛天数
//	{
//		for (int player = 0; player < players; player++)//遍历选手编号
//		{
//			//选取对应天数 day 所选维度 1<<day ，再通过异或操作将第 day 位翻转，保证双方选手仅第 day 位不同 -- “超立方体维度”
//			int opponent = player ^ (1 << day);//对手编号
//			if (player < opponent)
//				sched[day].push_back({ player + 1, opponent + 1 });
//		}
//	}
//}
//
//void printSched(vector<vector<pair<int, int>>>& sched)
//{
//	cout << "比赛日程表:" << endl;
//	for (int day = 0; day < sched.size(); day++)
//	{
//		cout << "第" << day + 1 << "天：";
//		for (const auto& match : sched[day])
//		{
//			cout << "(" << match.first << " vs " << match.second << ")";
//		}
//		cout << endl;
//	}
//}
//
//int main()
//{
//	int n = 0;
//	cout << "输入n（选手数为2^n，n不能小于2）:";
//	cin >> n;
//	if (n < 2)
//		cout << "n值小于2，结束程序";
//	int size = 1 << n;
//	vector<vector<pair<int, int>>> sched(n - 1);
//	makeSched(n, sched);
//	printSched(sched);
//	return 0;
//}


//7
//void createStation(vector<int>& station)
//{
//	int num = 0;
//	cout << "输入加油站数量：";
//	cin >> num;
//	cout << "依次输入加油站位置：";
//	for (; num > 0; num--)
//	{
//		int sta = 0;
//		cin >> sta;
//		station.push_back(sta);
//	}
//}
//
//void takeAns(int load, int n, vector<int>& station)
//{
//	int position = 0;//当前位置
//	vector<int> record;//加油站选择记录
//	station.push_back(load);
//	for (int a = 0; a < station.size(); )
//	{
//		//寻找当前最远的加油站
//		int far = -1;
//		while (a < station.size() && station[a] <= position + n)
//		{
//			far = a;
//			a++;
//		}
//		if (far == -1)
//		{
//			cout << "无法到达终点";
//			return;
//		}
//		//更新位置
//		position = station[far];
//		record.push_back(station[far]);
//		//终点结算
//
//		if (position >= load)
//		{
//			record.pop_back();
//			cout << "最少加油次数：" << record.size() << endl;
//			cout << "加油站选择：";
//			for (int a : record)
//				cout << a << " ";
//			return;
//		}
//	}
//}
//
//int main()
//{
//	int load = 0;
//	int n = 0;
//	cout << "输入总路程：";
//	cin >> load;
//	cout << "输入汽车满油行驶距离：";
//	cin >> n;
//	vector<int> station;
//	createStation(station);
//	takeAns(load, n, station);
//}


//8
//int main()
//{
//	int i = 0, j = 0;
//	vector<int> g, s;
//	cout << "输入孩子数量：";
//	cin >> i;
//	cout << "输入饼干数量：";
//	cin >> j;
//	cout << "依次输入每个孩子的胃口值：";
//	for (; i > 0; i--)
//	{
//		int a = 0;
//		cin >> a;
//		g.push_back(a);
//	}
//	cout << "依次输入每块饼干的尺寸：";
//	for (; j > 0; j--)
//	{
//		int a = 0;
//		cin >> a;
//		s.push_back(a);
//	}
//	sort(g.begin(), g.end());
//	sort(s.begin(), s.end());
//	int child = 0, ans = 0;
//	for (int cookie = 0; cookie < s.size(); cookie++)
//	{
//		//满足
//		if (s[cookie] >= g[child])
//		{
//			child++;
//			ans++;
//			if (ans >= g.size())
//			{
//				cout << ans;
//				return 0;
//			}
//		}
//	}
//	cout << ans;
//	return 0;
//}


//9
//void backtrack(vector<int>& nums, vector<bool>& visited, vector<int>& current, vector<vector<int>>& result) {
//	if (current.size() == nums.size())
//	{
//		result.push_back(current);// 保存结果
//		return;
//	}
//	for (int i = 0; i < nums.size(); i++) {
//		if (visited[i])
//			continue;
//		visited[i] = true;
//		current.push_back(nums[i]);
//		backtrack(nums, visited, current, result);//递归构造下一个元素
//		current.pop_back();
//		visited[i] = false;
//	}
//}
//
//vector<vector<int>> permute(vector<int>& nums) {
//	vector<vector<int>> result;
//	vector<int> current;
//	vector<bool> visited(nums.size(), false);
//	backtrack(nums, visited, current, result);
//	return result;
//}
//
//int main()
//{
//	vector<int> num;
//	cout << "输入数组内容：";
//	int n = 0;
//	while (1)
//	{
//		cin >> n;
//		num.push_back(n);
//		if (cin.get() == '\n')
//			break;
//	}
//	vector<vector<int>> ans = permute(num);
//	for (const auto& a : ans)
//	{
//		for (int b : a)
//		{
//			cout << b << " ";
//		}
//		cout << endl;
//	}
//	return 0;
//}


//10
void solve(int n, int row, vector<string>& board, vector<bool>& columns, vector<bool>& diagonals1, vector<bool>& diagonals2, vector<vector<string>>& solutions) {
    if (row == n)
    {
        solutions.push_back(board);//保存
        return;
    }
    for (int col = 0; col < n; col++)
    {
        if (columns[col] || diagonals1[row - col + n - 1] || diagonals2[row + col])
            continue;

        //放置皇后
        board[row][col] = 'Q';
        columns[col] = diagonals1[row - col + n - 1] = diagonals2[row + col] = true;

        //递归处理下一行
        solve(n, row + 1, board, columns, diagonals1, diagonals2, solutions);

        //回溯，撤销放置
        board[row][col] = '.';
        columns[col] = diagonals1[row - col + n - 1] = diagonals2[row + col] = false;
    }
}

vector<vector<string>> solveNQueens(int n) {
    vector<vector<string>> solutions;
    vector<string> board(n, string(n, '.'));
    vector<bool> columns(n, false);//列占用
    vector<bool> diagonals1(2 * n - 1, false);//主对角线占用
    vector<bool> diagonals2(2 * n - 1, false);//次对角线占用
    solve(n, 0, board, columns, diagonals1, diagonals2, solutions);
    return solutions;
}

int main() {
    int n = 8;
    vector<vector<string>> solutions = solveNQueens(n);
    cout << "共有 " << solutions.size() << " 种解法：" << endl;
    for (const auto& solution : solutions) {
        for (const string& row : solution) {
            cout << row << endl;
        }
        cout << endl;
    }
    return 0;
}