<?php
session_start();
require_once 'config/db.php';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $user_name = $_POST['user_name'];
    $user_password = $_POST['user_password'];
    $user_birth = $_POST['user_birth'];
    $user_email = $_POST['user_email'];
    $user_phone = $_POST['user_phone'];

    // 检查用户名是否存在
    $stmt = $pdo->prepare('SELECT * FROM users WHERE user_name = :user_name');
    $stmt->execute(['user_name' => $user_name]);
    if ($stmt->rowCount() > 0) {
        $_SESSION['error'] = '用户名已存在！';
        header('Location: register.php');
        exit();
    }

    // 加密密码
    $hashed_password = password_hash($user_password, PASSWORD_DEFAULT);

    // 插入新用户到数据库
    $stmt = $pdo->prepare('INSERT INTO users (user_name, user_password, user_birth, user_email, user_phone) 
                           VALUES (:user_name, :user_password, :user_birth, :user_email, :user_phone)');
    $stmt->execute([
        'user_name' => $user_name,
        'user_password' => $hashed_password,
        'user_birth' => $user_birth,
        'user_email' => $user_email,
        'user_phone' => $user_phone
    ]);

    $_SESSION['success'] = '注册成功！请登录';
    header('Location: login.php');
}
?>
