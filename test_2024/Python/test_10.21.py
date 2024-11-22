# # 1. 判断一个整数是否能被3、5、7整除
# def check_divisibility():
#     num = int(input("请输入一个整数: "))
#     if num % 3 == 0 and num % 5 == 0 and num % 7 == 0:
#         print("yes")
#     else:
#         print("no")

# check_divisibility()


# # 2. 统计列表中每个字母出现的次数并排序输出
# from collections import Counter

# def count_letters():
#     word_list = ["python", "computer", "book", "program"]
#     all_letters = "".join(word_list)  # 将所有单词拼接成一个字符串
#     letter_count = Counter(all_letters)  # 统计每个字母的出现次数
#     sorted_letter_count = sorted(letter_count.items(), key=lambda x: x[1], reverse=True)  # 按次数排序
    
#     # 输出结果
#     for letter, count in sorted_letter_count:
#         print(f"字母: {letter}, 出现次数: {count}")

# count_letters()


# # 3. 根据分数判断成绩等级
# def check_grade():
#     score = int(input("请输入分数: "))
#     assert 0 <= score <= 100, "分数不能为负数且不能大于100"  # 断言分数的合法性
#     if score < 60:
#         grade = "不及格"
#     elif 60 <= score < 80:
#         grade = "良好"
#     else:
#         grade = "优秀"
    
#     print(f"成绩等级: {grade}")

# # 调用函数
# check_grade()