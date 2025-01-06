# ---1---
# def sum_of_squares(N):
#     # 计算平方和 ∑_(k=1)^(k=N) k^2
#     return sum(k**2 for k in range(1, N+1))

# # 测试
# N = int(input("请输入 N 的值: "))
# result = sum_of_squares(N)
# print(f"从 1 到 {N} 的平方和是: {result}")



# ---2---
# main.py 程序

# # 导入 calculator 模块
# import calculator

# # 用户输入两个数字
# a = float(input("请输入第一个数字: "))
# b = float(input("请输入第二个数字: "))

# # 选择操作
# print("选择操作: ")
# print("1. 加法")
# print("2. 减法")
# print("3. 乘法")
# print("4. 除法")

# operation = input("请输入操作 (1/2/3/4): ")

# if operation == '1':
#     print(f"{a} + {b} = {calculator.add(a, b)}")
# elif operation == '2':
#     print(f"{a} - {b} = {calculator.subtract(a, b)}")
# elif operation == '3':
#     print(f"{a} * {b} = {calculator.multiply(a, b)}")
# elif operation == '4':
#     print(f"{a} / {b} = {calculator.divide(a, b)}")
# else:
#     print("无效的操作!")



# ---3---
# import math

# # 基类 Shape
# class Shape:
#     def __init__(self, name):
#         self.name = name
#         self.area = 0
#         self.perimeter = 0

#     def calArea(self):
#         raise NotImplementedError("calArea() 必须由派生类实现")

#     def calPerimeter(self):
#         raise NotImplementedError("calPerimeter() 必须由派生类实现")

#     def display(self):
#         print(f"图形名称: {self.name}")
#         print(f"周长: {self.perimeter}")
#         print(f"面积: {self.area}")

# # 派生类 Rectangle (矩形)
# class Rectangle(Shape):
#     def __init__(self, length, width):
#         super().__init__("矩形")
#         self.length = length
#         self.width = width
#         self.calArea()
#         self.calPerimeter()

#     def calArea(self):
#         self.area = self.length * self.width

#     def calPerimeter(self):
#         self.perimeter = 2 * (self.length + self.width)

# # 派生类 Triangle (三角形)
# class Triangle(Shape):
#     def __init__(self, a, b, c):
#         super().__init__("三角形")
#         self.a = a  # 三角形三边
#         self.b = b
#         self.c = c
#         self.calArea()
#         self.calPerimeter()

#     def calArea(self):
#         # 使用海伦公式计算面积
#         s = (self.a + self.b + self.c) / 2  # 半周长
#         self.area = math.sqrt(s * (s - self.a) * (s - self.b) * (s - self.c))

#     def calPerimeter(self):
#         self.perimeter = self.a + self.b + self.c

# # 派生类 Circle (圆)
# class Circle(Shape):
#     def __init__(self, radius):
#         super().__init__("圆")
#         self.radius = radius
#         self.calArea()
#         self.calPerimeter()

#     def calArea(self):
#         self.area = math.pi * self.radius ** 2

#     def calPerimeter(self):
#         self.perimeter = 2 * math.pi * self.radius

# # 测试代码
# if __name__ == "__main__":
#     # 创建矩形对象
#     rectangle = Rectangle(10, 5)
#     rectangle.display()

#     # 创建三角形对象
#     triangle = Triangle(3, 4, 5)
#     triangle.display()

#     # 创建圆形对象
#     circle = Circle(7)
#     circle.display()



# ---4---
# import numpy as np
# import matplotlib.pyplot as plt

# # 生成 X 的取值范围 [-1000, 1000]
# x = np.linspace(-1000, 1000, 400)  # 生成400个均匀间隔的点

# # 计算 Y = 2x^2 + 30x - 11.5
# y = 2 * x**2 + 30 * x - 11.5

# # 绘制函数图
# plt.plot(x, y, label="Y = 2x^2 + 30x - 11.5")

# # 添加标签和标题
# plt.xlabel('X')
# plt.ylabel('Y')
# plt.title('Graph of Y = 2x^2 + 30x - 11.5')

# # 添加网格
# plt.grid(True)

# # 显示图例
# plt.legend()

# # 显示图形
# plt.show()



# ---5---
# import random

# # 步骤 1: 生成1000个1000以内的随机整数并写入文件
# def write_random_numbers_to_file(filename):
#     # 生成1000个1000以内的随机整数
#     random_numbers = [random.randint(1, 1000) for _ in range(1000)]
    
#     # 将整数转换为字符串并使用逗号分隔
#     with open(filename, 'w') as file:
#         file.write(','.join(map(str, random_numbers)))

# # 步骤 2: 从文件中读取数据并排序
# def read_and_sort_numbers_from_file(filename):
#     with open(filename, 'r') as file:
#         # 读取文件中的数据，按逗号分隔并转换为整数
#         numbers = list(map(int, file.read().split(',')))
    
#     # 对读取的数字进行排序
#     numbers.sort()
    
#     # 打印排序后的结果
#     print("排序后的数字:")
#     print(numbers)

# # 主程序
# if __name__ == "__main__":
#     filename = 'random_numbers.txt'  # 文件名

#     # 写入随机数到文件
#     write_random_numbers_to_file(filename)
    
#     # 从文件读取数据并排序输出
#     read_and_sort_numbers_from_file(filename)



# ---6---
import numpy as np
import matplotlib.pyplot as plt

# 生成 X 的取值范围 [-2π, 2π]
x = np.linspace(-2 * np.pi, 2 * np.pi, 400)  # 生成400个点

# 计算正弦值 Y = sin(x)
y = np.sin(x)

# 绘制正弦函数曲线
plt.plot(x, y, label="sin(x)")

# 添加标题和标签
plt.title("正弦函数 sin(x) 曲线")
plt.xlabel("x")
plt.ylabel("sin(x)")

# 添加网格
plt.grid(True)

# 显示图例
plt.legend()

# 显示图形
plt.show()
