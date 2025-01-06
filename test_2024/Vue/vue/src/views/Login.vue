<template>
  <div class="login-container" :class="theme">
    <el-card class="login-card">
      <h2>登录</h2>
      <el-form :model="loginForm" :rules="rules" ref="loginForm">
        <el-form-item prop="username">
          <el-input v-model="loginForm.username" placeholder="用户名"></el-input>
        </el-form-item>
        <el-form-item prop="password">
          <el-input v-model="loginForm.password" type="password" placeholder="密码"></el-input>
        </el-form-item>
        <el-form-item label="验证码" prop="captcha">
          <el-input v-model="loginForm.captcha" placeholder="请输入验证码"></el-input>
          <span class="captcha">{{ captcha }}</span>
          <el-button @click="refreshCaptcha">刷新验证码</el-button>
        </el-form-item>
        <el-form-item>
          <el-button type="primary" @click="handleLogin" style="width: 100%">登录</el-button>
        </el-form-item>
        <el-form-item>
          <router-link to="/register">没有账号？立即注册</router-link>
        </el-form-item>
      </el-form>
      <el-button @click="toggleTheme" class="theme-toggle-btn">
        切换到{{ theme === 'light' ? '黑夜' : '白天' }}模式
      </el-button>
    </el-card>
  </div>
</template>

<script>
import { generateCaptcha } from '@/utils/captcha';

export default {
  name: 'Login',
  data() {
    return {
      loginForm: {
        username: '',
        password: '',
        captcha: ''
      },
      rules: {
        username: [
          { required: true, message: '请输入用户名', trigger: 'blur' }
        ],
        password: [
          { required: true, message: '请输入密码', trigger: 'blur' }
        ],
        captcha: [
          { required: true, message: '请输入验证码', trigger: 'blur' }
        ]
      },
      captcha: '',
      theme: localStorage.getItem('theme') || 'light'
    }
  },
  created() {
    this.refreshCaptcha();
  },
  methods: {
    refreshCaptcha() {
      this.captcha = generateCaptcha();
    },
    handleLogin() {
      this.$refs.loginForm.validate(valid => {
        if (valid) {
          if (this.loginForm.captcha !== this.captcha) {
            this.$message.error('验证码错误');
            return;
          }
          // 验证用户信息
          const users = JSON.parse(localStorage.getItem('users') || '[]');
          const user = users.find(user => user.username === this.loginForm.username && user.password === this.loginForm.password);
          if (user) {
            localStorage.setItem('token', 'dummy-token'); // 模拟存储一个假令牌
            this.$router.push('/home');
          } else {
            this.$message.error('用户名或密码错误');
          }
        }
      });
    },
    toggleTheme() {
      this.theme = this.theme === 'light' ? 'dark' : 'light';
      localStorage.setItem('theme', this.theme);
    }
  }
}
</script>

<style scoped>
.login-container {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: #f5f7fa;
}

.login-card {
  width: 400px;
  transition: background-color 0.3s, color 0.3s;
}

.captcha-image {
  cursor: pointer;
  margin-top: 10px;
}

.captcha {
  display: inline-block;
  margin-left: 10px;
  font-weight: bold;
}

.theme-toggle-btn {
  margin-top: 20px;
}

.light {
  background-color: #ffffff;
  color: #000000;
}

.dark {
  background-color: #1a1a1a;
  color: #ffffff;
}

.light .login-card {
  background-color: #ffffff;
  color: #000000;
}

.dark .login-card {
  background-color: #2c3e50;
  color: #ffffff;
}

.el-input {
  transition: background-color 0.3s, color 0.3s;
}

.light .el-input__inner {
  background-color: #ffffff;
  color: #000000;
}

.dark .el-input__inner {
  background-color: #2c3e50;
  color: #ffffff;
}
</style>