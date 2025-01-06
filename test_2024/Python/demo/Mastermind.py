import random

class Game:
    def __init__(self, color_file: str, outcome_file: str):
        # 使用彩钉配置文件和结果文件路径进行初始化
        self.file_io = FileIO(color_file, outcome_file)
        self.max_pegs, self.colors = self.file_io.read_colors()  # 获取彩钉数量和颜色列表
        self.rounds = Rounds(self.max_pegs, self.colors)  # 设置游戏回合
        self.input_handler = Input()

    def start_game(self) -> None:
        print("+================================================+")
        print("|                                                |")
        print("|             Welcome to Mastermind!             |")
        print("|                                                |")
        print("+================================================+")
        print("The game will use the colors defined in the settings file.")
        print("The maximum number of colored pegs in each rouch is set to 3.")
        print("The available colors which will be used are Yellow, White, Blue, Green, Red, Black.")
        input("Press the enter key to continue...")
        for round_number in range(1, 6):  # 假设最多进行5轮
            print(f"Begining Round {round_number}")
            guess = self.input_handler.get_guess(self.colors, self.max_pegs)  # 获取玩家的猜测
            result = self.rounds.check_guess(guess)  # 检查猜测并获取分数
            print(result)
            if self.rounds.is_game_over():
                print("You guessed correctly! The game is over!")
                break
        # 保存最终得分和正确的颜色序列
        self.save_outcome(self.rounds.total_score, [peg.color for peg in self.rounds.computer_color_grid.pegs])

    def save_outcome(self, score: int, secret_code: list[str]) -> None:
        result = f"Game over!\nFinal score: {score} \nThe correct color sequence is: {', '.join(secret_code)}"
        self.file_io.write_outcome(result)  # 将游戏结果写入 outcome.txt
        print(result)



class Peg:
    def __init__(self, color: str, value: int):
        self.color = color  # 彩钉的颜色
        self.value = value  # 彩钉的分数



class ColorGrid:
    def __init__(self):
        self.pegs = []  # 存储彩钉的列表
        self.noOfPegs = 0  # 彩钉数量

    def add_peg(self, peg: Peg) -> None:
        self.pegs.append(peg)
        self.noOfPegs += 1



class Rounds:
    def __init__(self, max_pegs: int, colors: list[str]) -> None:
        self.max_pegs = max_pegs  # 每轮的彩钉数量
        self.colors = colors  # 可用颜色列表
        self.computer_color_grid = self.generate_computer_sequence()  # 计算机的秘密颜色序列
        self.round_guesses = []  # 玩家猜测记录
        self.total_score = 0  # 总分
        self.max_rounds = 5  # 最大回合数

    def generate_computer_sequence(self) -> ColorGrid:
        color_grid = ColorGrid()
        for _ in range(self.max_pegs):
            color = random.choice(self.colors)  # 随机选择颜色
            value = self.colors.index(color) + 1  # 为颜色分配分数（1到N）
            peg = Peg(color, value)
            color_grid.add_peg(peg)
        return color_grid

    def check_guess(self, guess: list[str]) -> str:
        score = 0
        for i, guess_color in enumerate(guess):
            if guess_color == self.computer_color_grid.pegs[i].color:
                score += self.computer_color_grid.pegs[i].value  # 如果猜对了则加分
        self.total_score = score
        return f"Player Score: {score}"

    def is_game_over(self) -> bool:
        return self.total_score == sum(peg.value for peg in self.computer_color_grid.pegs)



class FileIO:
    def __init__(self, color_filename: str, outcome_filename: str):
        self.color_filename = color_filename  # 彩钉配置文件路径
        self.outcome_filename = outcome_filename  # 结果文件路径

    def read_colors(self) -> tuple[int, list[str]]:
        with open(self.color_filename, 'r', encoding='utf-8') as file:
            lines = file.readlines()
        max_pegs = int(lines[0].strip())  # 第一行包含彩钉数量
        colors = [line.strip() for line in lines[1:]]  # 后续行包含颜色名称
        return max_pegs, colors

    def write_outcome(self, result: str) -> None:
        with open(self.outcome_filename, 'w', encoding='utf-8') as file:
            file.write(result)



class Validation:
    @staticmethod
    def is_valid_guess(guess: list[str], colors: list[str], max_pegs: int) -> bool:
        return len(guess) == max_pegs and all(color in colors for color in guess)



class Input:
    def get_guess(self, colors: list[str], max_pegs: int) -> list[str]:
        while True:
            print(f"Please enter a guess with {max_pegs} colors, selecting from the following list (separate colors with spaces):")
            print(", ".join(colors))
            guess = input("Your guess: ").strip().split()
            if Validation.is_valid_guess(guess, colors, max_pegs):
                return guess
            else:
                print("Invalid input. Please make sure your guess has the correct number of colors and all colors are from the list.")



# 开始游戏
if __name__ == "__main__":
    color_file = "D:/basic software/VS Project/test_2024/Python/demo/color.txt"  # 彩钉配置文件路径
    outcome_file = "D:/basic software/VS Project/test_2024/Python/demo/outcome.txt"  # 结果文件路径
    game = Game(color_file, outcome_file)
    game.start_game()
