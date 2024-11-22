# a = {'a': '1', 'b': '2', 'c': '3'}

# # (1) 遍历 keys 值
# print("遍历 keys:")
# for key in a.keys():
#     print(key)

# # (2) 遍历 values 值
# print("\n遍历 values:")
# for value in a.values():
#     print(value)

# # (3) 遍历字典项（键-值）
# print("\n遍历字典项（键-值）:")
# for key, value in a.items():
#     print(f"{key}: {value}")

def analyze_sentence(sentence):
    # 使用空格分割句子，得到单词列表
    words = sentence.split()
    word_count = len(words)
    total_length = sum(len(word) for word in words)
    average_length = total_length / word_count if word_count > 0 else 0

    print(f"单词数量: {word_count}")
    print(f"单词平均长度: {average_length:.2f}")

sentence = "new empty set object set(iterable) new set object Build an unordered collection of unique elements."
analyze_sentence(sentence)
