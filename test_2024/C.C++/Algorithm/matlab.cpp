//(a) 定义状态。
//(b) 找出转移矩阵，并为该马尔科夫链绘制转移图。
//(c) 讨论该链的正规性和遍历性。链中是否有吸收状态？
//(d) 假设一名患者处于恢复期。她在3年后仍然健康的概率是多少？
//(e) 与此马尔科夫链相关的稳态概率向量是什么？结合(c)中的发现，评论你的结果。


/*a
As -- Asymptomatic (无症状)
Sy -- Symptomatic (并发症)
Re -- Recovery (恢复期)
He -- Healthy (健康)
De -- Death (死亡)
*/


/*b

P = [
0.95  0.04  0     0     0.01
0     0     0.995 0     0.005
0     0     0.09  0.9   0.01
0     0     0     0.99  0.01
0     0     0     0     1
];
Gr = digraph(P > 0);
plot(Gr, 'NodeLabel', {'Asymptomatic', 'Symptomatic', 'Recovery', 'Healthy', 'Death'});
title('转移图');

*/

/*c

k = 1;
Reg = false;
while (k < 100)
    if all(all(P ^ k > 0))
        Reg = true;
        break;
    end
    k = k + 1;
end
fprintf('此链是否具有正规性 -- %s\n', mat2str(Reg));

Abs = diag(P) == 1;
state = {'Asymptomatic', 'Symptomatic', 'Recovery', 'Healthy', 'Death'};
state_num = find(Abs);
fprintf('此链的吸收状态 -- %s\n', state{state_num});

n = size(P, 1);
mat = (P > 0);
for k = 2:n
    mat = mat | (P ^ k > 0);
end
Erg = all(mat(:) == 1) && ~any(diag(P) == 1 & sum(P, 2) == 1);
fprintf('此链是否具有遍历性 -- %s\n', mat2str(Erg));
*/

/*d
Re_He = 0.9 ^ 9;
fprintf('3年后仍然健康的概率 -- %.4f\n', Re_He);
*/

/*e
syms pi1 pi2 pi3 pi4 pi5;
pi = [pi1, pi2, pi3, pi4, pi5];
eqs = pi * P == pi;
eqs = [eqs, sum(pi) == 1];
sol = solve(eqs, pi);
state = double([sol.pi1, sol.pi2, sol.pi3, sol.pi4, sol.pi5]);
disp('稳态概率向量:')
disp(state);
*/