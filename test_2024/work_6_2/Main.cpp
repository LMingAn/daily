#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <regex>
#include <sstream>
using namespace std;

vector<string> InputKeyboard()
{
    vector<string> expressions;
    string exp;
    cout << "请输入一个大整数表达式（输入空行结束）：";
    getchar();
    while (getline(cin, exp) && !exp.empty()) {
        expressions.push_back(exp);
        cout << "请输入一个大整数表达式（输入空行结束）：";
    }
    return expressions;
}

vector<string> InputFile(const string& fname)
{
    vector<string> exps;
    ifstream file(fname);
    string exp;
    while (getline(file, exp))
        exps.push_back(exp);
    return exps;
}

void Write(const string& fname, const vector<string>& exps, const vector<string>& results)
{
    ofstream file(fname);
    for (size_t i = 0; i < exps.size(); ++i)
        file << exps[i] << " = " << results[i] << endl;
}

void Output(const vector<string>& exps, const vector<string>& results)
{
    for (size_t i = 0; i < exps.size(); ++i)
        cout << exps[i] << " = " << results[i] << endl;
}


bool Judgment(const string& exp)
{
    regex pattern(R"(^\s*(sqrt\(\s*\d+\s*\)|pow\(\s*\d+\s*,\s*\d+\s*\)|\d+\s*[\+\-\*/]\s*\d+)\s*$)");
    return regex_match(exp, pattern);
}

string Operation(const string& exp)
{
    if (exp.find("sqrt") != string::npos) {
        size_t start = exp.find("(") + 1;
        size_t end = exp.find(")");
        string number = exp.substr(start, end - start);
        long long num = stoll(number);
        return to_string(static_cast<long long>(std::sqrt(num)));
    }
    else if (exp.find("pow") != string::npos) {
        size_t start1 = exp.find("(") + 1;
        size_t end1 = exp.find(",");
        string base = exp.substr(start1, end1 - start1);
        size_t start2 = end1 + 1;
        size_t end2 = exp.find(")");
        string exponent = exp.substr(start2, end2 - start2);
        long long baseNum = stoll(base);
        long long expNum = stoll(exponent);
        return to_string(static_cast<long long>(std::pow(baseNum, expNum)));
    }
    else {
        istringstream iss(exp);
        long long num1, num2;
        char op;
        iss >> num1 >> op >> num2;

        ostringstream oss;
        try {
            switch (op) {
            case '+':
                oss << num1 + num2;
                break;
            case '-':
                oss << num1 - num2;
                break;
            case '*':
                oss << num1 * num2;
                break;
            case '/':
                if (num2 == 0) {
                    throw runtime_error("除数为0");
                }
                oss << num1 / num2;
                break;
            default:
                throw runtime_error("运算错误");
            }
        }
        catch (const exception& e) {
            return "Error: " + string(e.what());
        }
        return oss.str();
    }
}

#include <cmath>

string sqrt(const string& x)
{
    long long num = stoll(x);
    return to_string(static_cast<long long>(std::sqrt(num)));
}

string pow(const string& x, const string& y)
{
    long long base = stoll(x);
    long long expsonent = stoll(y);
    return to_string(static_cast<long long>(std::pow(base, expsonent)));
}

int main()
{
    int in = 0;
    vector<string> exps, results;
    do
    {
        cout << "欢迎使用大整数算术运算器\n";
        cout << "========================\n";
        cout << "1 ----- 从键盘输入表达式\n";
        cout << "2 ----- 从文本输入表达式\n";
        cout << "0 ----- 退出系统\n";
        cout << "请输入指令：";
        cin >> in;
        switch (in)
        {
        case 1:
            exps = InputKeyboard();
            for (const auto& expsr : exps)
            {
                if (Judgment(expsr))
                    results.push_back(Operation(expsr));
                else
                    results.push_back("Invalid exp");
            }
            Output(exps, results);
            Write("Write.txt", exps, results);
            break;
        case 2:
            exps = InputFile("Input.txt");
            for (const auto& expsr : exps)
            {
                if (Judgment(expsr))
                    results.push_back(Operation(expsr));
                else
                    results.push_back("Invalid exp");
            }
            Output(exps, results);
            Write("Write.txt", exps, results);
            break;
        }
    } while (in);
    return 0;
}