<template>
  <div>
    <AppNavbar />
    <div class="register">
      <h2>注册</h2>
      <form @submit.prevent="handleRegister">
        <div>
          <label for="username">用户名</label>
          <input type="text" id="username" v-model="username" required />
        </div>
        <div>
          <label for="password">密码</label>
          <input type="password" id="password" v-model="password" required />
        </div>
        <div>
          <label for="email">邮箱</label>
          <input type="email" id="email" v-model="email" required />
        </div>
        <div>
          <label for="phone">联系电话</label>
          <input type="text" id="phone" v-model="phone" required />
        </div>
        <button type="submit">注册</button>
        <p>
          已有账户？ <router-link to="/login">登录</router-link>
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
  name: 'AppRegister',
  components: {
    AppNavbar,
    AppFooter,
  },
  data() {
    return {
      username: '',
      password: '',
      email: '',
      phone: '',
    };
  },
  methods: {
    handleRegister() {
      const newUser = {
        username: this.username,
        password: this.password,
        email: this.email,
        phone: this.phone,
      };
      console.log('注册成功:', newUser);
      this.$router.push({ name: 'Login' });
    },
  },
};
</script>

<style scoped>
/* 注册样式 */
.register {
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
