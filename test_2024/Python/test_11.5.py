import converter

# 输入整数
num = 100

# 调用模块中的函数并输出结果
print(f"整数 {num} 转换为十六进制: {converter.to_hex(num)}")
print(f"整数 {num} 转换为八进制: {converter.to_oct(num)}")
print(f"整数 {num} 转换为二进制: {converter.to_bin(num)}")
