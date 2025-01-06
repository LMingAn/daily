<template>
  <div>
    <AppNavbar />
    <div class="login">
      <h2>登录</h2>
      <form @submit.prevent="handleLogin">
        <div>
          <label for="username">用户名</label>
          <input type="text" id="username" v-model="username" required />
        </div>
        <div>
          <label for="password">密码</label>
          <input type="password" id="password" v-model="password" required />
        </div>
        <button type="submit">登录</button>
        <p>
          没有账户？ <router-link to="/register">注册</router-link>
        </p>
      </form>
    </div>
    <AppFooter />
  </div>
</template>

<script>
import AppNavbar from '../components/AppNavbar.vue';
import AppFooter from '../components/AppFooter.vue';

export default {
  name: 'AppLogin',
  components: {
    AppNavbar,
    AppFooter,
  },
  data() {
    return {
      username: '',
      password: '',
    };
  },
  methods: {
    handleLogin() {
      const user = { username: this.username, password: this.password };
      localStorage.setItem('user', JSON.stringify(user));
      this.$router.push({ name: 'Dashboard' });
    },
  },
};
</script>

<style scoped>
/* 登录样式 */
.login {
  width: 300px;
  margin: 50px auto;
  padding: 20px;
  border: 1px solid #ccc;
  border-radius: 8px;
  background-color: #f9f9f9;
}

form {
  display: flex;
  flex-direction: column;
}

form div {
  margin-bottom: 10px;
}

form label {
  margin-bottom: 5px;
}

form input {
  padding: 8px;
  font-size: 16px;
  border: 1px solid #ccc;
  border-radius: 4px;
}

form button {
  padding: 10px;
  font-size: 16px;
  background-color: #007bff;
  color: white;
  border: none;
  border-radius: 4px;
}

form button:hover {
  background-color: #0056b3;
}

p {
  text-align: center;
}

router-link {
  color: #007bff;
  text-decoration: none;
}

router-link:hover {
  text-decoration: underline;
}
</style>
