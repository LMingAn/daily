# import numpy as np

# # 创建一个 8x8 的棋盘样式矩阵
# board = np.zeros((8, 8), dtype=int)

# # 利用切片操作设置棋盘样式
# board[::2, 1::2] = 1  # 设置偶数行的奇数列为1
# board[1::2, ::2] = 1  # 设置奇数行的偶数列为1

# print(board)


# import numpy as np

# # 创建一个 5x5 的随机矩阵
# matrix = np.random.rand(5, 5)  # 随机生成 5x5 的矩阵

# # 归一化操作
# min_value = matrix.min()
# max_value = matrix.max()
# normalized_matrix = (matrix - min_value) / (max_value - min_value)

# print("原始矩阵:")
# print(matrix)
# print("\n归一化后的矩阵:")
# print(normalized_matrix)


import numpy as np

# 创建一个长度为 10 的随机数组
array = np.random.rand(10)

# 找到最大值的索引并替换为 -100
array[array.argmax()] = -100

print("修改后的数组:")
print(array)
