# import matplotlib.pyplot as plt
# import numpy as np

# # 数据
# zhangsan = (90, 55, 40, 65)
# lisi = (85, 62, 54, 20)
# subjects = ['Math', 'Science', 'English', 'History']

# # 设置 x 轴位置
# x = np.arange(len(subjects))

# # 绘制并列条形图
# plt.bar(x - 0.2, zhangsan, width=0.4, label='Zhangsan', hatch='/', color='skyblue')
# plt.bar(x + 0.2, lisi, width=0.4, label='Lisi', hatch='\\', color='orange')

# # 添加图例和标签
# plt.xlabel('Subjects')
# plt.ylabel('Scores')
# plt.title('Comparison of Scores')
# plt.xticks(x, subjects)
# plt.legend()

# plt.show()


# import matplotlib.pyplot as plt

# # 数据
# cars = ['AUDI', 'BMW', 'FORD', 'TESLA', 'JAGUAR', 'MERCEDES']
# data = [23, 17, 35, 29, 12, 41]

# # 绘制饼状图
# plt.figure(figsize=(8, 8))
# explode = [0, 0, 0.1, 0, 0, 0]  # 突出 FORD
# colors = ['#ff9999', '#66b3ff', '#99ff99', '#ffcc99', '#c2c2f0', '#ffb3e6']
# plt.pie(data, labels=cars, autopct='%1.1f%%', startangle=140, explode=explode, colors=colors)

# plt.title('Car Sales Distribution')
# plt.show()



import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt

# 读取 iris 数据集
df = pd.read_csv('D:\\basic software\\VS Project\\test_2024\\Python\\iris.csv')

# 使用 seaborn 进行两两特征散点图绘制
sns.pairplot(df, hue='species', diag_kind='kde', palette='Set2')

plt.show()
