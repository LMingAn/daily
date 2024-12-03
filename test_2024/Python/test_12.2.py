# arr = [1, 2, 0, 0, 4, 0]

# # 使用列表推导式找非零元素的索引
# nonzero_indices = [i for i, value in enumerate(arr) if value != 0]

# print(f"非零元素的位置索引: {nonzero_indices}")


# import random

# # 创建一个 10x30 的随机矩阵（元素为 0-1 的浮点数）
# rows, cols = 10, 30
# matrix = [[random.random() for _ in range(cols)] for _ in range(rows)]

# # 计算 axis=0（列方向）的平均值、最大值、最小值
# mean_axis0 = [sum(row[i] for row in matrix) / rows for i in range(cols)]
# max_axis0 = [max(row[i] for row in matrix) for i in range(cols)]
# min_axis0 = [min(row[i] for row in matrix) for i in range(cols)]

# # 计算 axis=1（行方向）的平均值、最大值、最小值
# mean_axis1 = [sum(row) / cols for row in matrix]
# max_axis1 = [max(row) for row in matrix]
# min_axis1 = [min(row) for row in matrix]

# # 输出结果
# print("Axis=0 平均值:", mean_axis0)
# print("Axis=0 最大值:", max_axis0)
# print("Axis=0 最小值:", min_axis0)
# print("Axis=1 平均值:", mean_axis1)
# print("Axis=1 最大值:", max_axis1)
# print("Axis=1 最小值:", min_axis1)


def read_stock_data(file_path):
    """
    读取股票日线数据，并存入字典。
    字典键为日期，值为收盘价。
    """
    stock_data = {}  # 存储结果
    try:
        with open(file_path, 'r') as file:
            lines = file.readlines()
            for line in lines[1:]:  # 跳过第一行标题
                data = line.strip().split(",")  # 按逗号分割每行数据
                if len(data) >= 5:  # 确保数据格式正确
                    date = data[0]  # 日期
                    close_price = float(data[4])  # 收盘价
                    stock_data[date] = close_price
    except FileNotFoundError:
        print(f"文件 {file_path} 未找到，请检查路径！")
    except ValueError:
        print("文件内容格式有误，请检查数据！")
    return stock_data

# 示例调用
file_path = r"D:\basic software\VS Project\test_2024\Python\600000.txt"  # 替换为实际文件路径
stock_dict = read_stock_data(file_path)

# 打印结果
if stock_dict:
    for date, close_price in stock_dict.items():
        print(f"日期: {date}, 收盘价: {close_price}")
