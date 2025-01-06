<?php
session_start();
require_once 'config/db.php';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $user_name = $_POST['user_name'];
    $user_password = $_POST['user_password'];

    // 查询用户
    $stmt = $pdo->prepare('SELECT * FROM users WHERE user_name = :user_name');
    $stmt->execute(['user_name' => $user_name]);
    $user = $stmt->fetch(PDO::FETCH_ASSOC);

    if ($user && password_verify($user_password, $user['user_password'])) {
        // 登录成功，保存用户信息到session
        $_SESSION['user_id'] = $user['user_id'];
        $_SESSION['user_name'] = $user['user_name'];
        header('Location: dashboard.php');  // 登录后跳转到用户仪表盘
    } else {
        $_SESSION['error'] = '用户名或密码错误';
        header('Location: login.php');
    }
}
?>
