/* eslint-disable */
// src/router/index.js
import Vue from 'vue';
import Router from 'vue-router';
import AppTopics from '../views/AppTopics.vue';
import AppLogin from '../views/AppLogin.vue';  // 确保引入 AppLogin.vue
import AppRegister from '../views/AppRegister.vue';  // 确保引入 AppRegister.vue
import TopicsDetail from '../components/TopicsDetail.vue';  // 假设你已经创建了 TopicsDetail 组件

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: '/',
      name: 'AppTopics',
      component: AppTopics,
    },
    {
      path: '/login',
      name: 'Login',
      component: AppLogin,  // 确保 AppLogin 组件存在
    },
    {
      path: '/register',
      name: 'Register',
      component: AppRegister,  // 确保 AppRegister 组件存在
    },
    {
      path: '/topic/:id',
      name: 'TopicsDetail',
      component: TopicsDetail,  // 确保 TopicsDetail 组件存在
      props: true,  // 使路由参数作为 props 传递给 TopicsDetail 组件
    },
  ],
});
