<template>
  <div class="navbar">
    <div class="navbar-container">
      <router-link to="/" class="logo">我的百科</router-link>
      <div class="navbar-links">
        <router-link to="/" class="nav-link">首页</router-link>
        <router-link to="/topics" class="nav-link">话题</router-link>
        <router-link to="/about" class="nav-link">关于</router-link>
        
        <!-- 判断用户是否登录 -->
        <div v-if="!isLoggedIn">
          <router-link to="/login" class="nav-link">登录</router-link>
          <router-link to="/register" class="nav-link">注册</router-link>
        </div>
        <div v-else>
          <span class="nav-link">{{ userName }}</span>
          <button @click="logout" class="nav-link logout-btn">登出</button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      isLoggedIn: false,  // 控制登录状态
      userName: '',       // 用户名
    };
  },
  created() {
    // 在组件创建时检查用户登录状态
    this.checkLoginStatus();
  },
  methods: {
    // 检查用户是否已登录
    checkLoginStatus() {
      // 可以从 Vuex 获取登录状态，或者从后端 API 获取用户信息
      const user = localStorage.getItem('user');  // 假设使用 localStorage 存储用户信息
      if (user) {
        this.isLoggedIn = true;
        this.userName = JSON.parse(user).user_name;  // 设置用户名
      }
    },

    // 处理登出
    logout() {
      // 清除登录状态
      localStorage.removeItem('user');
      this.isLoggedIn = false;
      this.$router.push('/login');  // 登出后跳转到登录页
    }
  }
};
</script>

<style scoped>
.navbar {
  background-color: #2c3e50;
  color: white;
  padding: 10px;
}
.logo {
  font-size: 1.5rem;
  font-weight: bold;
  color: #ecf0f1;
  text-decoration: none;
}
.navbar-container {
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.navbar-links {
  display: flex;
  gap: 20px;
}
.nav-link {
  color: white;
  text-decoration: none;
}
.logout-btn {
  background: none;
  color: white;
  border: none;
  cursor: pointer;
}
</style>
