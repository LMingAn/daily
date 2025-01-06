import random
class Peg:
    """代表每个彩钉的类"""
    def __init__(self, color: str, value: int):
        self.color = color  # 彩钉的颜色
        self.value = value  # 彩钉的分数
class ColorGrid:
    """表示一个彩钉序列的类"""
    def __init__(self):
        self.pegs = []  # 保存彩钉列表
        self.noOfPegs = 0  # 彩钉的数量
    def add_peg(self, peg: Peg) -> None:
        """添加一个彩钉到彩钉序列"""
        self.pegs.append(peg)
        self.noOfPegs += 1
class FileIO:
    """用来进行文件操作的类"""
    def __init__(self, color_filename: str, outcome_filename: str):
        self.color_filename = color_filename  # 颜色配置文件路径
        self.outcome_filename = outcome_filename  # 结果输出文件路径
    def read_colors(self) -> tuple[int, list[str]]:
        """从颜色文件中读取颜色列表"""
        with open(self.color_filename, 'r', encoding='utf-8') as file:
            lines = file.readlines()
        max_pegs = int(lines[0].strip())  # 第一行是彩钉数量
        colors = [line.strip() for line in lines[1:]]  # 后续行是颜色
        return max_pegs, colors
    def write_outcome(self, result: str) -> None:
        """将游戏结果写入文件"""
        with open(self.outcome_filename, 'w', encoding='utf-8') as file:
            file.write(result)
class Input:
    """输入相关的类"""
    def get_guess(self, colors: list[str], max_pegs: int) -> list[str]:
        """获取玩家输入的彩钉猜测"""
        while True:
            print(f"请输入一个包含 {max_pegs} 个颜色的猜测，颜色从以下列表中选择（用空格分隔）：")
            print(", ".join(colors))
            guess = input("你的猜测: ").strip().split()
            if len(guess) == max_pegs and all(color in colors for color in guess):
                return guess
            else:
                print("输入无效，请确保输入的颜色数量正确并且从列表中选择颜色，用空格分隔。")
class Game:
    """游戏主类，控制游戏流程"""
    def __init__(self, color_file: str, outcome_file: str):
        # 初始化时需要传入两个文件路径，一个是颜色配置文件，一个是结果文件
        self.file_io = FileIO(color_file, outcome_file)
        self.max_pegs, self.colors = self.file_io.read_colors()  # 获取彩钉数量和颜色列表
        self.rounds = Rounds(self.max_pegs, self.colors)  # 游戏的轮数设置
        self.input_handler = Input()
    def start_game(self) -> None:
        """开始游戏"""
        print("欢迎来到珠玑妙算游戏！")
        for round_number in range(1, 6):  # 假设最多有5轮
            print(f"第{round_number}轮开始！")
            guess = self.input_handler.get_guess(self.colors, self.max_pegs)  # 获取玩家猜测
            result = self.rounds.check_guess(guess)  # 检查玩家猜测的结果
            print(result)
            if self.rounds.is_game_over():
                print("你已经猜对了！游戏结束！")
                break
        # 获取最终分数和正确的彩钉顺序，并保存游戏结果
        self.save_outcome(self.rounds.total_score, [peg.color for peg in self.rounds.computer_color_grid.pegs])

    def save_outcome(self, score: int, secret_code: list[str]) -> None:
        """游戏结束，输出分数并写入结果文件"""
        result = f"游戏结束！\n最终分数：{score}分\n正确的彩钉顺序是：{', '.join(secret_code)}"
        self.file_io.write_outcome(result)  # 将游戏结果写入到 outcome.txt 文件
        print(result)
class Rounds:
    """处理游戏轮次的类"""
    def __init__(self, max_pegs: int, colors: list[str]) -> None:
        self.max_pegs = max_pegs  # 每轮最大彩钉个数
        self.colors = colors  # 彩钉颜色列表
        self.computer_color_grid = self.generate_computer_sequence()  # 计算机生成的彩钉序列
        self.round_guesses = []  # 玩家猜测的记录
        self.total_score = 0  # 总分数
        self.max_rounds = 5  # 最大轮数
    def generate_computer_sequence(self) -> ColorGrid:
        """生成计算机的彩钉顺序"""
        color_grid = ColorGrid()
        for _ in range(self.max_pegs):
            color = random.choice(self.colors)
            value = self.colors.index(color) + 1  # 彩钉的分数（1到N）
            peg = Peg(color, value)
            color_grid.add_peg(peg)
        return color_grid
    def check_guess(self, guess: list[str]) -> str:
        """检查玩家的猜测并计算得分"""
        score = 0
        for i, guess_color in enumerate(guess):
            if guess_color == self.computer_color_grid.pegs[i].color:
                score += self.computer_color_grid.pegs[i].value  # 如果猜对了，就加分
        self.total_score = score
        return f"这一轮你猜对了 {score} 分"
    def is_game_over(self) -> bool:
        """判断游戏是否结束"""
        return self.total_score == sum(peg.value for peg in self.computer_color_grid.pegs)
# 启动游戏
if __name__ == "__main__":
    color_file = 'D:/basic software/VS Project/test_2024/Python/demo/colors.txt'  # 颜色配置文件路径
    outcome_file = 'D:/basic software/VS Project/test_2024/Python/demo/outcome.txt'  # 结果输出文件路径
    game = Game(color_file, outcome_file)
    game.start_game()