class Person:
    def __init__(self, name, age, gender):
        self.name = name
        self.age = age
        self.gender = gender

    def personInfo(self):
        """打印个人信息"""
        print(f"姓名: {self.name}, 年龄: {self.age}, 性别: {self.gender}")

p1 = Person("张三", 25, "男")
p1.personInfo()

class Student(Person):
    def __init__(self, name, age, gender, college, class_):
        super().__init__(name, age, gender)
        self.college = college
        self.class_ = class_

    def personInfo(self):
        """打印学生信息，包含学院和班级"""
        super().personInfo()
        print(f"学院: {self.college}, 班级: {self.class_}")

s1 = Student("李四", 20, "女", "计算机学院", "2023级1班")
s1.personInfo()
