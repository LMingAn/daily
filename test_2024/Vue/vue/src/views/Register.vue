<template>
  <div class="register-container" :class="theme">
    <el-card class="register-card">
      <h2>注册</h2>
      <el-form :model="registerForm" :rules="rules" ref="registerForm" label-width="80px">
        <el-form-item label="用户名" prop="username">
          <el-input v-model="registerForm.username" placeholder="请输入用户名"></el-input>
        </el-form-item>
        <el-form-item label="密码" prop="password">
          <el-input v-model="registerForm.password" type="password" placeholder="请输入密码"></el-input>
        </el-form-item>
        <el-form-item label="确认密码" prop="confirmPassword">
          <el-input v-model="registerForm.confirmPassword" type="password" placeholder="请再次输入密码"></el-input>
        </el-form-item>
        <el-form-item label="姓名" prop="name">
          <el-input v-model="registerForm.name" placeholder="请输入姓名"></el-input>
        </el-form-item>
        <el-form-item label="性别" prop="gender">
          <el-radio-group v-model="registerForm.gender">
            <el-radio label="male">男</el-radio>
            <el-radio label="female">女</el-radio>
          </el-radio-group>
        </el-form-item>
        <el-form-item label="验证码" prop="captcha">
          <el-input v-model="registerForm.captcha" placeholder="请输入验证码"></el-input>
          <span class="captcha">{{ captcha }}</span>
          <el-button @click="refreshCaptcha">刷新验证码</el-button>
        </el-form-item>
        <el-form-item>
          <el-button type="primary" @click="handleRegister" style="width: 100%">注册</el-button>
        </el-form-item>
        <el-form-item>
          <router-link to="/login">已有账号？立即登录</router-link>
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
  name: 'Register',
  data() {
    // 密码验证规则
    const validatePass = (rule, value, callback) => {
      if (value === '') {
        callback(new Error('请输入密码'))
      } else {
        if (this.registerForm.confirmPassword !== '') {
          this.$refs.registerForm.validateField('confirmPassword')
        }
        callback()
      }
    }
    // 确认密码验证规则
    const validatePass2 = (rule, value, callback) => {
      if (value === '') {
        callback(new Error('请再次输入密码'))
      } else if (value !== this.registerForm.password) {
        callback(new Error('两次输入密码不一致!'))
      } else {
        callback()
      }
    }

    return {
      registerForm: {
        username: '',
        password: '',
        confirmPassword: '',
        name: '',
        gender: 'male',
        captcha: ''
      },
      rules: {
        username: [
          { required: true, message: '请输入用户名', trigger: 'blur' },
          { min: 3, max: 20, message: '长度在 3 到 20 个字符', trigger: 'blur' }
        ],
        password: [
          { required: true, validator: validatePass, trigger: 'blur' },
          { min: 6, message: '密码长度至少为6个字符', trigger: 'blur' }
        ],
        confirmPassword: [
          { required: true, validator: validatePass2, trigger: 'blur' }
        ],
        name: [
          { required: true, message: '请输入姓名', trigger: 'blur' }
        ],
        gender: [
          { required: true, message: '请选择性别', trigger: 'change' }
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
    handleRegister() {
      this.$refs.registerForm.validate(valid => {//表单验证
        if (valid) {
          if (this.registerForm.captcha !== this.captcha) {
            this.$message.error('验证码错误');
            return;
          }
          // 保存用户信息到本地存储
          const users = JSON.parse(localStorage.getItem('users') || '[]');
          users.push({ ...this.registerForm });
          localStorage.setItem('users', JSON.stringify(users));
          this.$message.success('注册成功！');
          this.$router.push('/login');
        } else {
          return false
        }
      })
    },
    refreshCaptcha() {
      this.captcha = generateCaptcha();
    },
    toggleTheme() {
      this.theme = this.theme === 'light' ? 'dark' : 'light';
      localStorage.setItem('theme', this.theme);
    }
  }
}
</script>

<style scoped>
.register-container {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: #f5f7fa;
}

.register-card {
  width: 500px;
  transition: background-color 0.3s, color 0.3s;
}

h2 {
  text-align: center;
  margin-bottom: 20px;
}

.el-form-item:last-child {
  margin-bottom: 0;
  text-align: center;
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
  background-color: #2c3e50;
  color: #ffffff;
}

.light .register-card {
  background-color: #ffffff;
  color: #000000;
}

.dark .register-card {
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