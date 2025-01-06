<?php
$host = 'localhost'; // 数据库主机
$dbname = 'test'; // 数据库名
$username = 'root'; // 数据库用户名
$password = '123lan??'; // 数据库密码

// 创建数据库连接
try {
    $pdo = new PDO("mysql:host=$host;dbname=$dbname", $username, $password);
    // 设置PDO错误模式为异常
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (PDOException $e) {
    echo 'Connection failed: ' . $e->getMessage();
}
?>
